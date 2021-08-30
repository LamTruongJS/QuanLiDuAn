using CoreLibrary.Areas.Reader.Data;
using CoreLibrary.Areas.Reader.Models;
using CoreLibrary.Helper.Model;
using CoreLibrary.Helper.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLibrary.Areas.Reader.Controllers
{
    [Area("reader")] // area name is reader
    [Route("reader/[controller]/[action]")]
    public class LoggingController : Controller
    {

        private readonly EBookContext _db = null;
        private readonly UserManager<User> _userManager = null;
        private readonly SignInManager<User> _signInManager = null;
        private readonly RoleManager<IdentityRole> _roleManager = null;
        private readonly EmailService _emailService = null;
        private readonly UserService _userService = null;
        private readonly LinkService _linkService = null;


        public LoggingController(EBookContext db,
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            EmailService emailService,
            UserService userService,
            LinkService linkService,
            RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _emailService = emailService;
            _userManager = userManager;
            _signInManager = signInManager;
            _userService = userService;
            _linkService = linkService;
            _roleManager = roleManager;
        }
        // ------------------------------------- //
        #region Sign In
        [Route("~/sign-in")]
        public async Task<IActionResult> Index()
        {
            return View();
        }
        [HttpPost("~/sign-in")]
        public async Task<IActionResult> Index(SignInModel model, string ReturnUrl)
        {
            if(ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.IsRemember, false);
                if(result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(ReturnUrl))
                        return LocalRedirect(ReturnUrl);
                    return RedirectToAction("Index","Home");
                }
            }
            ViewBag.Message = "Account incorrect";
            return View(model);
        }

        #endregion

        // ------------------------------------- //

        #region Sign up
        [Route("~/sign-up")]
        public async Task<IActionResult> SignUp()
        {
            ViewBag.CountryId = new SelectList(await _db.Countries.OrderBy(c => c.Name).ToListAsync(), "Id", "Name");
            return View();
        }
        [HttpPost("~/sign-up")]
        public async Task<IActionResult> SignUp(SignUpModel model)
        {
            if (ModelState.IsValid)
            {
                User user = new User()
                {
                    Email = model.Email,
                    UserName = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    CountryId = model.CountryId,
                    Avatar = "df.jpg"
                };
                var result = await _userManager.CreateAsync(user, model.Password);

                var resultRole = await _userManager.AddToRoleAsync(user, "Reader");

                if (result.Succeeded && resultRole.Succeeded)
                {
                    if (model.IsSignInNow)
                    {
                        var result0 = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);
                        if (result0.Succeeded)
                            return RedirectToAction("Index", "Home");
                    }                        
                    else
                        return RedirectToAction("Index", "Logging");
                }
                else
                {
                    foreach (var err in result.Errors)
                        ModelState.AddModelError("", err.Description);
                    foreach (var err in resultRole.Errors)
                        ModelState.AddModelError("", err.Description);
                }
            }
            ViewBag.CountryId = new SelectList(await _db.Countries.OrderBy(c => c.Name).ToListAsync(), "Id", "Name");
            return View(model);
        }
        #endregion

        // ------------------------------------- //
        #region Forget Password
        [Route("~/forget-password")]
        public async Task<IActionResult> Forget(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return View();
            }
            else
            {
                User user = await _userManager.FindByNameAsync(email);
                string token = await _userManager.GeneratePasswordResetTokenAsync(user);

                string tokenUrl = _linkService.GetTokenUrl("reset-password", token, user.Id);

                EmailModel emailModel = new EmailModel()
                {
                    Body = "ForgetPasswordEmail",
                    Subject = "Reset Password in E-Book",
                    ToEmails = new List<string>() { email },
                    PlaceHolders = new List<KeyValuePair<string, string>>()
                    {
                        new KeyValuePair<string, string>("{{UserName}}", user.LastName + " " + user.FirstName),
                        new KeyValuePair<string, string>("{{TokenLink}}",tokenUrl)
                    }
                };

                await _emailService.SendAsync(emailModel);

                return Content(tokenUrl);
            }
            
        }
        #endregion
        // ------------------------------------- //

        #region Resend email
        [Route("~/resend")]
        public IActionResult Resend()
        {
            return View();
        }
        #endregion
        // ------------------------------------- //

        [Route("~/sign-out")]
        public async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(Index));
        }

        // ------------------------------------- //

        #region Reset password
        [Route("~/reset-password")]
        public IActionResult ResetPassword(string uid, string token)
        {
            TokenPackageModel tokenPackage = new TokenPackageModel()
            {
                UID = uid,
                Token = token
            };

            ResetPasswordModel resetPassword = new ResetPasswordModel() { TokenPackage = tokenPackage };
            return View(resetPassword);
        }
        [HttpPost("~/reset-password")]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await _userManager.FindByIdAsync(model.TokenPackage.UID);
                string token = model.TokenPackage.Token.Replace(' ', '+');
                var result = await _userManager.ResetPasswordAsync(user, token, model.Password);
                if(result.Succeeded)
                {
                    if (model.IsSignInNow)
                    {
                        await _signInManager.SignInAsync(user, false);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                        return RedirectToAction("Index", "Logging");                        
                }
                foreach (var err in result.Errors)
                    ModelState.AddModelError("", err.Description);
            }
            return View(model);
        }
        #endregion
        // ------------------------------------- //
    }
}
