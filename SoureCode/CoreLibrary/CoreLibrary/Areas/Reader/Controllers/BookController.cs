using CoreLibrary.Areas.Reader.Data;
using CoreLibrary.Areas.Reader.Models.Book;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using CoreLibrary.Helper.Services;
using Microsoft.AspNetCore.Identity;
using SautinSoft;
using System.Security.Claims;

namespace CoreLibrary.Areas.Reader.Controllers
{
    [Area("reader")] // area name is reader
    [Route("reader/[controller]/[action]")]
    public class BookController : Controller
    {
        private readonly EBookContext db = null;
        private readonly IWebHostEnvironment _webHostEnvironment = null;
        private readonly TextService _textService = null;
        private readonly UserManager<User> _userManager = null;
        private readonly SignInManager<User> _signInManager = null;
        public BookController(EBookContext _db, IWebHostEnvironment webHostEnvironment, TextService textService,
            UserManager<User> userManager, SignInManager<User> signInManager)
        {
            db = _db;
            _webHostEnvironment = webHostEnvironment;
            _textService = textService;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        // ------------------------------------- //
        #region Create The Book
        [Route("~/reader/book-create")]
        [Authorize(Roles = "Author")]
        public async Task<IActionResult> Create(string? success)
        {
            ViewBag.Success = success;
            ViewBag.LanguageId = new SelectList(await db.Languages.OrderBy(lg => lg.Name).ToListAsync(), "Id", "Name");
            ViewBag.CategoryId = new SelectList(await db.Categories.OrderBy(cg => cg.Name).ToListAsync(), "Id", "Name");
            return View();
        }
        [HttpPost("~/reader/book-create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BookModel model)
        {
            string message = "";
            string currentId = db.Books.OrderByDescending(bk => bk.DateTimePosted).Take(1).Select(bk => bk.Id).FirstOrDefault();
            string id = _textService.GenerateId(currentId, "BK");
            
            var result = await UploadFile("respo\\pdf", "respo\\thumbnail", model.Path);
            // item1 : file name pdf
            // item2 : file name thumbnail

            User user = await _userManager.FindByEmailAsync(User.FindFirst("Email").Value);
            Book book = new Book()
            {
                Id = id,
                Name = model.Name,
                AboutBook = model.AboutBook,
                AuthorId = user.Id,
                CategoryId = model.CategoryId,
                LanguageId = model.LanguageId,
                PdfUrl = result.Item1,
                ThumbnailUrl = result.Item2,
                Price = model.Price,
                //DateTimePosted = DateTime.Now, ktra xem nó có thực sự tự động thêm vào hay không
                Review = model.Reviews,
                ReducedPrice = -1
                
            };

            await db.Books.AddAsync(book);
            int rowEffects = await db.SaveChangesAsync();
            if (rowEffects > 0)
                message = "true";
            else message = "false";

            ViewBag.LanguageId = new SelectList(await db.Languages.OrderBy(lg => lg.Name).ToListAsync(), "Id", "Name");
            ViewBag.CategoryId = new SelectList(await db.Categories.OrderBy(cg => cg.Name).ToListAsync(), "Id", "Name");
            return RedirectToAction(nameof(Create), new { success = message });
        }
        #endregion

        // ------------------------------------- //
        #region Detail The Book
        [Route("~/reader/book-detail/{id}")]
        public async Task<IActionResult> Detail(string id)
        {
            Book book = await db.Books.FindAsync(id);
            return View(book);
        }
        #endregion

        // ------------------------------------- //
        #region Edit The Book
        public IActionResult Edit()
        {
            return View();
        }
        #endregion

        // ------------------------------------- //
        #region Delete The Book
        public IActionResult Delete()
        {
            return View();
        }
        #endregion

        //----------------------------------------//
        #region Category Detail
        [Route("~/reader/category-detail/{id}")]
        public async Task<IActionResult> CategoryDetail(string id)
        {
            Category category = await db.Categories.FindAsync(id);
            ViewBag.CategoryName = category.Name;
            return View(category);
        }
        #endregion

        // ------------------------------------- //
        #region Add to Favorite
        [HttpPost("~/reader/book-toggle-favorite/{id}")]
        public async Task<JsonResult> ToggleFavorite(string id)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var inter = db.Interactions.Where(it => it.BookId == id && it.UserId == userId).FirstOrDefault();

            if(inter is null)
            {
                inter = new Interaction()
                {
                    BookId = id,
                    UserId = userId,
                    IsLove = true,
                    
                };
                db.Interactions.Add(inter);
            }
            else
            {
                inter.IsLove = !inter.IsLove;
            }

            
            int result = await db.SaveChangesAsync();
            if (result > 0)
                if (inter.IsLove)
                    return Json("ADD");
                else return Json("REMOVE");
            return Json("NO");
        }
        #endregion

        // ------------------------------------- //

        // ------------------------------------- //
        #region Function
        private async Task<Tuple<string, string>> UploadFile(string folder, string folderImg, IFormFile file)
        {           
            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            string fileNameImg = Guid.NewGuid().ToString() + ".tiff";
            

            string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folder + "\\" + fileName);
            FileStream fileStream = new FileStream(serverFolder, FileMode.Create);
            await file.CopyToAsync(fileStream);
            fileStream.Close();
            
            PdfFocus f = new PdfFocus();

            f.OpenPdf(new FileStream(serverFolder, FileMode.Open));
            

            if (f.PageCount > 0)
            {               
                string serverFolderImg = Path.Combine(_webHostEnvironment.WebRootPath, folderImg + "\\" + fileNameImg);
                f.ImageOptions.Dpi = 300;
                f.ToImage(serverFolderImg, 1);
            }
            Tuple<string, string> tuple = new Tuple<string, string>(fileName, fileNameImg);
            return tuple;
        }
        #endregion
    }
}
