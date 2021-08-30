using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLibrary.Areas.Admin.Controllers
{
    [Area("admin")] // area name is admin
    [Route("admin/[controller]/[action]")]
    public class StatisticalController : Controller
    {
        [Route("~/admin/statistical/books")]
        public IActionResult Books()
        {
            return View();
        }
        [Route("~/admin/statistical/turnover")]
        public async Task<IActionResult> Turnover()
        {
            return View();
        }
        [Route("~/admin/statistical/views")]
        public async Task<IActionResult> Views()
        {
            return View();
        }
    }
}
