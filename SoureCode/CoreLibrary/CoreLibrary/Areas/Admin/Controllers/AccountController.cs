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
    [Area("admin")] // area name is reader
    [Route("admin/[controller]/[action]")]
    public class AccountController : Controller
    {
        private readonly EBookContext _db = null;
        private readonly UserManager<User> _userManager;

        public AccountController(EBookContext db, UserManager<User> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        // ----------------------------- //
        #region Admin account
        [Route("~/admin/accounts/admin")]
        public async Task<IActionResult> Admins()
        {
            var admins = await _userManager.GetUsersInRoleAsync("Admin");
            return View(admins);
        }
        #endregion

        // ----------------------------- //
        #region Author account
        [Route("~/admin/accounts/author")]
        public async Task<IActionResult> Authors()
        {
            var authors = await _userManager.GetUsersInRoleAsync("Author");
            return View(authors);
        }
        #endregion

        // ---------------------------- //
        #region Block account
        [Route("~/admin/accounts/lockout")]
        public async Task<IActionResult> Blocked()
        {
            var locked = await _db.Users.Where(us => us.LockoutEnd > DateTime.Now).ToListAsync();
            return View(locked);
        }
        #endregion

        // ------------------------------ //
        #region Reader account
        [Route("~/admin/accounts/reader")]
        public async Task<IActionResult> Readers()
        {
            var readers = await _userManager.GetUsersInRoleAsync("Reader");
            return View(readers);
        }
        #endregion
    }
}
