using CoreLibrary.Areas.Reader.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLibrary.Areas.Admin.Controllers
{
    [Area("admin")] // area name is admin
    [Route("admin/[controller]/[action]")]
    public class BookController : Controller
    {
        private readonly EBookContext _db = null;
        private readonly UserManager<User> _userManager;

        public BookController(EBookContext db, UserManager<User> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        // --------------------------- //
        [Route("~/admin/manager/books")]
        public async Task<IActionResult> Books()
        {
            var books = await _db.Books.ToListAsync();
            return View(books);
        }
        public async Task<IActionResult> Authors()
        {
            var authors = await _userManager.GetUsersInRoleAsync("Author");
            return View(authors);
        }
    }
}
