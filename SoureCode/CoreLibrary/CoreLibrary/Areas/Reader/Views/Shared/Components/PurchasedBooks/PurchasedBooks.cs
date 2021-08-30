using CoreLibrary.Areas.Reader.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLibrary.Areas.Reader.Views.Shared.Components.PurchasedBooks
{
    [ViewComponent]
    public class PurchasedBooks : ViewComponent
    {
        private readonly EBookContext _db = null;
        public PurchasedBooks(EBookContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync(dynamic model)
        {
            return View(model);
        }
    }
}
