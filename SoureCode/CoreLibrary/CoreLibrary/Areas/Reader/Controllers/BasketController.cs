using CoreLibrary.Areas.Reader.Data;
using CoreLibrary.Helper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLibrary.Areas.Reader.Controllers
{
    [Area("reader")] // area name is reader
    [Route("reader/[controller]/[action]")]
    public class BasketController : Controller
    {
        private readonly EBookContext _db = null;
        public BasketController(EBookContext db)
        {
            _db = db;
        }

        [Route("~/reader/basket")]
        public async Task<IActionResult> Index()
        {
            string sessionBasket = HttpContext.Session.GetString("Basket");
            var model = await _db.Books.Where(b => sessionBasket.Contains(b.Id)).ToListAsync();
            return View(model);
        }

        //---------------------------------------//
        #region Add to basket
        [HttpGet("~/reader/basket-add/{id}")]
        public JsonResult AddToBasket(string id)
        {
            var session = HttpContext.Session.GetString("Basket");
            string message = "";
            if(session is null)
            {
                HttpContext.Session.SetString("Basket", id);
                message = "Added book to basket";
            }
            else
            {
                
                var value = HttpContext.Session.GetString("Basket");
                if (!value.Contains(id))
                {
                    HttpContext.Session.SetString("Basket", value + ";" + id);
                    message = "Added book to basket";
                }
                else
                    message = "The book already exists in the basket";
            }         
            session = HttpContext.Session.GetString("Basket");
            ViewBag.Basket = session.Split(';').Length;
            return Json(message);
        }
        #endregion
        //---------------------------------------//
        //---------------------------------------//
        //---------------------------------------//
        //---------------------------------------//
        //---------------------------------------//
        //---------------------------------------//
    }
}
