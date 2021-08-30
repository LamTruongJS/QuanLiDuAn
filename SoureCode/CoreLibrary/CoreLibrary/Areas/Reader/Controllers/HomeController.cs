using CoreLibrary.Areas.Reader.Data;
using CoreLibrary.Areas.Reader.Models.Home;
using CoreLibrary.Helper.Model;
using CoreLibrary.Helper.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Session;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using CoreLibrary.Helper;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreLibrary.Areas.Reader.Controllers
{
    [Area("reader")] // area name is reader
    [Route("reader/[controller]/[action]")]
    public class HomeController : Controller
    {
        private readonly UserManager<User> _userManager = null;
        private readonly LinkService _linkService = null;
        private readonly EmailService _emailService = null;
        private readonly EBookContext _db = null;
        private readonly IWebHostEnvironment _webHostEnvironment = null;
        private readonly SignInManager<User> _signInManager = null;

        public HomeController(UserManager<User> userManager, LinkService linkService, 
            EmailService emailService, EBookContext db, SignInManager<User> signInManager,
            IWebHostEnvironment webHostEnvironment)
        {
            _userManager = userManager;
            _linkService = linkService;
            _emailService = emailService;
            _db = db;
            _signInManager = signInManager;
            _webHostEnvironment = webHostEnvironment;
        }

        #region First Header Menu
        [Route("~/reader/about-us")]
        public IActionResult About()
        {
            return View();
        }
        [Route("~/reader/contact-us")]
        public IActionResult Contact()
        {
            return View();
        }
        [Route("~/reader/help")]
        public IActionResult Help()
        {
            return View();
        }
        #endregion


        #region Menu Item

        // -------------------------------------- //
        #region Home
        [Route("~/")]
        [Route("~/reader/home")]
        public async Task<IActionResult> Index()
        {
            var result = _db.Baskets.GroupBy(b => b.BookId)
                            .Select(group => new { BookId = group.Key, Count = group.Count() })
                            .OrderByDescending(b => b.Count).Take(1).FirstOrDefault();
            var book = await _db.Books.FindAsync(result.BookId);
            return View(book);
        }
        #endregion

        // -------------------------------------- //

        #region Best View
        [Route("~/reader/best-view")]
        public IActionResult BestView()
        {
            return View();
        }
        #endregion

        // -------------------------------------- //

        #region Lastest Books
        [Route("~/reader/latest-books")]
        public IActionResult LatestBooks()
        {
            return View();
        }
        #endregion

        // -------------------------------------- //

        #region Latest News
        [Route("~/reader/latest-news")]
        public IActionResult LatestNews()
        {
            return View();
        }
        #endregion

        // -------------------------------------- //

        #region Advanced Search
        [Route("~/reader/advanced-search")]
        public async Task<IActionResult> AdvancedSearch()
        {
            ViewBag.LanguageId = new SelectList(await _db.Languages.OrderBy(lg => lg.Name).ToListAsync(), "Id", "Name");
            ViewBag.CategoryId = new SelectList(await _db.Categories.OrderBy(cg => cg.Name).ToListAsync(), "Id", "Name");
            return View(new AdvancedSearchModel());
        }
        [HttpPost("~/reader/advanced-search")]
        public async Task<IActionResult> AdvancedSearch(AdvancedSearchModel model)
        {
            ViewBag.LanguageId = new SelectList(await _db.Languages.OrderBy(lg => lg.Name).ToListAsync(), "Id", "Name");
            ViewBag.CategoryId = new SelectList(await _db.Categories.OrderBy(cg => cg.Name).ToListAsync(), "Id", "Name");
            return View(model);
        }
        #endregion

        // -------------------------------------- //

        #region Favorite Books
        [Route("~/reader/favorite-books")]
        [Authorize]
        public IActionResult FavoriteBooks()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ViewBag.userId = userId;
            return View();
        }
        #endregion

        // ------------------------------------- //

        #region User Profile
        [Route("~/reader/user-profile")]
        [Authorize]
        public async Task<IActionResult> UserProfile()
        {
            User user = await _userManager.FindByEmailAsync(User.FindFirst("Email").Value);
            return View(user);
        }
        [Route("~/reader/user-profile/change-avatar")]
        [Authorize]
        public async Task<IActionResult> ChangeAvatar()
        {
            User user = await _userManager.FindByEmailAsync(User.FindFirst("Email").Value);
            return View(user);
        }
        [HttpPost("~/reader/user-profile/change-avatar")]
        [Authorize]
        public async Task<IActionResult> ChangeAvatar(IFormCollection formData)
        {
            string imgbase64 = formData["avatar"];
            byte[] bytes = Convert.FromBase64String(imgbase64.Split(',')[1]);

            // lấy tên ảnh
            string fileName = Guid.NewGuid() + ".jpeg";

            string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, "assets\\img\\user" + "\\" + fileName);

            // ghi file vào máy chủ
            FileStream stream = new FileStream(serverFolder, FileMode.Create);
            stream.Write(bytes, 0, bytes.Length);
            stream.Flush();

            User user = await _userManager.FindByEmailAsync(User.FindFirst("Email").Value);

            user.Avatar = fileName;

            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(UserProfile));
        }
        #endregion

        // ------------------------------------- //

        #region Authors
        [Route("~/reader/authors")]
        public async Task<IActionResult> Authors()
        {
            var authors = await _db.Users.Where(au => !string.IsNullOrEmpty(au.AboutAuthor)).ToListAsync();
            return View(authors);
        }
        #endregion
        
        // ------------------------------------- //

        #region Author detail
        [Route("~/reader/author-detail/{id}")]
        public async Task<IActionResult> AuthorDetail(string id)
        {
            User user = await _userManager.FindByIdAsync(id);
            return View(user);
        }
        #endregion
        
        // ------------------------------------- //

        #region Register Author
        [Route("~/reader/register-to-author")]
        public IActionResult RegisterAuthor()
        {
            return View();
        }
        [HttpPost("~/reader/register-to-author")]
        public async Task<IActionResult> RegisterAuthor(RegisterAuthorModel model)
        {
            if (ModelState.IsValid)
            {
                string email = User.FindFirst("Email").Value;
                User user = await _userManager.FindByNameAsync(email);
                string token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                string tokenUrl = _linkService.GetTokenUrl("confirm-email", token, user.Id);

                EmailModel emailModel = new EmailModel()
                {
                    Body = "ConfirmEmail",
                    Subject = "Register become author in E-Book",
                    ToEmails = new List<string>() { email },
                    PlaceHolders = new List<KeyValuePair<string, string>>()
                    {
                        new KeyValuePair<string, string>("{{UserName}}", user.LastName + " " + user.FirstName),
                        new KeyValuePair<string, string>("{{TokenLink}}",tokenUrl)
                    }
                };
                HttpContext.Session.SetString("Name", "Tung");
                await _emailService.SendAsync(emailModel);
                // viết html xác nhận email
                // viết thêm action nhận token và xử lý confirm
                // viết thêm hành động biến nó trở thành author
                HttpContext.Session.Set<RegisterAuthorModel>("RegisterAuthorModel", model);
                return Content("Please check your email");
            }
            return View(model);
        }
        #endregion

        // ------------------------------------- //

        #region Confirm Email
        [HttpGet("~/confirm-email")]
        public async Task<IActionResult> ConfirmEmail(string uid, string token)
        {
            User user = await _userManager.FindByIdAsync(uid);
            token = token.Replace(' ', '+');
            var resultConfirm = await _userManager.ConfirmEmailAsync(user, token);
            var resultRole = await _userManager.AddToRoleAsync(user, "Author");
            if (resultConfirm.Succeeded && resultRole.Succeeded)
            {
                RegisterAuthorModel registerAuthor = HttpContext.Session.Get<RegisterAuthorModel>("RegisterAuthorModel");
                user.AboutAuthor = registerAuthor.AboutAuthor;
                user.PhoneNumber = registerAuthor.Phone;
                user.BackupEmail = registerAuthor.BackupEmail;
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }    
                
            string errMessage = "";
            foreach (var err in resultConfirm.Errors)
                errMessage += err.Description + "\n";
            foreach (var err in resultRole.Errors)
                errMessage += err.Description + "\n";
            return Content(errMessage + "\n" + token);
        }
        #endregion

        // ------------------------------------- //

        #region Respo
        [Route("~/reader/respo")]
        [Authorize]
        public async Task<IActionResult> Respo()
        {
            string userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var purchased = await _db.Baskets.Where(bs => bs.UserId == userId).Select(bs => bs.Book).ToListAsync();
            return View(purchased);
        }
        #endregion

        // ------------------------------------- //
        [Route("~/reader/rating/{id}")]
        [Authorize]
        public async Task<IActionResult> Rating(string id)
        {
            Book book = await _db.Books.FindAsync(id);
            string user = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ViewBag.UID = user;
            return View(book);
        }
        [HttpPost("~/reader/rating/{id}")]
        [Authorize]
        public async Task<IActionResult> Rating(IFormCollection formData)
        {
            short star = short.Parse(formData["star"]);
            string userId = formData["userId"];
            string bookId = formData["bookId"];
            var inter = _db.Interactions.Where(it => it.UserId == userId && it.BookId == bookId).FirstOrDefault();
            if(inter is null)
            {
                inter = new Interaction()
                {
                    BookId = bookId,
                    UserId = userId,
                    Evaluation = star                 
                };
                _db.Interactions.Add(inter);
            }
            else
            {
                inter.Evaluation = star;
            }
            ViewBag.Success = true;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Rating));
        }

        // --------------------------------------- //
        #region Search keywork
        [Route("~/reader/search-book")]
        public IActionResult SearchBook(string keywork)
        {
            ViewBag.Kw = keywork;
            return View();
        }
        #endregion


        #endregion
    }
}
