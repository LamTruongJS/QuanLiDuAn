using CoreLibrary.Areas.Reader.Data;
using CoreLibrary.Areas.Reader.Models.Payment;
using CoreLibrary.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreLibrary.Areas.Reader.Controllers
{
    [Area("reader")] // area name is reader
    [Route("reader/[controller]/[action]")]
    public class PaymentController : Controller
    {
        private readonly EBookContext _db = null;
        private readonly UserManager<User> _userManager = null;
        public PaymentController(EBookContext db, UserManager<User> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        // ------------------------------- //
        #region Payment a book
        [Route("~/payment/{id}")]
        [Authorize]
        public async Task<IActionResult> Index(string id)
        {
            string userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            User user = await _userManager.FindByIdAsync(userId);
            Book book = await _db.Books.FindAsync(id);            

            PaymentBookModel model = new PaymentBookModel()
            {
                AvatarUrl = book.ThumbnailUrl,
                Author = book.Author.LastName + " " + book.Author.FirstName,
                Name = book.Name,
                Price = book.Price,
                Id = id
            };

            if (!string.IsNullOrEmpty(user.HolderName) && !string.IsNullOrEmpty(user.BankNumber))
            {
                model.CardHolderName = user.HolderName;
                model.CardNumber = user.BankNumber;
            }

            return View(model);
        }
        [HttpPost("~/payment/{id}")]
        [Authorize]
        public async Task<IActionResult> Index(PaymentBookModel model,string id)
        {
            string userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            if (ModelState.IsValid)
            {
                User user = await _userManager.FindByIdAsync(userId);
                if (model.IsRemember)
                {               
                    user.BankNumber = model.CardNumber;
                    user.HolderName = model.CardHolderName;
                }
                else
                {
                    user.BankNumber = null;
                    user.HolderName = null;
                }
                Basket basket = new Basket()
                {
                    BookId = id,
                    UserId = userId,
                    Price = model.Price
                };
                _db.Baskets.Add(basket);
                int result = await _db.SaveChangesAsync();
                if (result == 0) return NotFound();
                ViewBag.Success = true;
                return View(new PaymentBookModel());
            }
            return View(model);
        }
        #endregion

        // ------------------------------- //
        #region Payment basket
        [Route("~/payment-basket")]
        public async Task<IActionResult> PaymentBasket()
        {
            string basket = HttpContext.Session.GetString("Basket");
            PaymentBasketModel basketModel = new PaymentBasketModel()
            {
                BookIds = basket
            };
            return View(basketModel);
        }

        [HttpPost("~/payment-basket")]
        [Authorize]
        public async Task<IActionResult> PaymentBasket(PaymentBasketModel model)
        {
            string userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            if (ModelState.IsValid)
            {
                User user = await _userManager.FindByIdAsync(userId);
                if (model.IsRemember)
                {
                    user.BankNumber = model.CardNumber;
                    user.HolderName = model.CardHolderName;
                }
                else
                {
                    user.BankNumber = null;
                    user.HolderName = null;
                }
                Book[] books = await _db.Books.Where(bk => model.BookIds.Contains(bk.Id)).ToArrayAsync();
                Basket[] baskets = new Basket[books.Length];
                for(int i = 0; i < books.Length; i++)
                {
                    Basket basket = new Basket()
                    {
                        BookId = books[i].Id,
                        UserId = userId,
                        Price = books[i].Price
                    };
                    baskets[i] = basket;
                }
                
                await _db.Baskets.AddRangeAsync(baskets);
                int result = await _db.SaveChangesAsync();
                if (result == 0) return NotFound();
                ViewBag.Success = true;
                HttpContext.Session.SetString("Basket", "");
                PaymentBasketModel basketModel = new PaymentBasketModel()
                {
                    BookIds = ""
                };
                return View(basketModel);
            }
            return View(model);
        }
        #endregion
    }
}
