using CoreLibrary.Areas.Reader.Data;
using CoreLibrary.Areas.Reader.Models.Author;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
    [Authorize(Roles = "Author")]
    public class AuthorController : Controller
    {
        private readonly EBookContext _db = null;
        public AuthorController(EBookContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        #region Detail and Edit Book published
        [Route("~/reader/author/manager-books/detail/{id}")]
        public async Task<IActionResult> Detail(string id)
        {
            Book book = await _db.Books.FindAsync(id);
            BookDetailModel model = new BookDetailModel()
            {
                Id = id,
                Name = book.Name,
                AboutBook = book.AboutBook,
                CategoryId = book.CategoryId,
                LanguageId = book.LanguageId,
                Price = book.Price,
                ReducePrice = book.ReducedPrice,
                Review = book.Review,
                Sold = book.Baskets.Count,
                Sales = book.Baskets.Sum(bs => bs.Price)
            };
            ViewBag.LanguageId = new SelectList(await _db.Languages.OrderBy(lg => lg.Name).ToListAsync(), "Id", "Name");
            ViewBag.CategoryId = new SelectList(await _db.Categories.OrderBy(cg => cg.Name).ToListAsync(), "Id", "Name");
            return View(model);
        }
        [HttpPost("~/reader/author/manager-books/detail/{id}")]
        public async Task<IActionResult> Detail(BookDetailModel model, string id)
        {
            ViewBag.LanguageId = new SelectList(await _db.Languages.OrderBy(lg => lg.Name).ToListAsync(), "Id", "Name");
            ViewBag.CategoryId = new SelectList(await _db.Categories.OrderBy(cg => cg.Name).ToListAsync(), "Id", "Name");
            if (ModelState.IsValid)
            {
                Book book = await _db.Books.FindAsync(model.Id);
                book.Name = model.Name;
                book.LanguageId = model.LanguageId;
                book.CategoryId = model.CategoryId;
                book.Price = model.Price;
                book.ReducedPrice = model.ReducePrice;
                book.AboutBook = model.AboutBook;
                book.Review = model.Review;

                await _db.SaveChangesAsync();
                ViewBag.Success = true;
            }
            return View(model);
        }
        #endregion
        //----------------------------------------------------//

        [Route("~/reader/author/manager-books")]
        [Authorize(Roles = "Author")]
        public async Task<IActionResult> Manager()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var books = await _db.Books.Where(bk => bk.AuthorId == userId).ToListAsync();
            return View(books);
        }
    }
}
