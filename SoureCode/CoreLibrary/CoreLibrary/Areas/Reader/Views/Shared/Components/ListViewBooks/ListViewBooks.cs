using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Dynamic;
using CoreLibrary.Areas.Reader.Data;
using CoreLibrary.Helper;
using Microsoft.EntityFrameworkCore;
using CoreLibrary.Areas.Reader.Models.Home;

namespace CoreLibrary.Areas.Reader.Views.Home.Components.BooksView
{
    [ViewComponent]
    public class ListViewBooks : ViewComponent
    {
        private readonly EBookContext _db = null;
        public ListViewBooks(EBookContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync(bool isPaging, BookOptionEnum option, string categoryId, string userId,
            string keywork, AdvancedSearchModel advModel)
        {
            IEnumerable<Book> books = null;
            switch (option)
            {
                case BookOptionEnum.Best:
                    var result = await _db.Baskets.GroupBy(b => b.BookId)
                            .Select(group => new { BookId = group.Key, Count = group.Count() })
                            .OrderByDescending(b => b.Count).Take(8).ToListAsync();

                    books = result.Select((g, c) => { return _db.Books.Find(g.BookId); }).ToList();
                    break;
                case BookOptionEnum.Latest:
                    books = await _db.Books.OrderByDescending(bk => bk.DateTimePosted).Take(8).ToListAsync();
                    break;
                case BookOptionEnum.Trending:
                    books = await _db.Books.Where(bk => bk.DateTimePosted > DateTime.Now.AddDays(-30)).
                        OrderByDescending(bk => bk.View).Take(8).ToListAsync();
                    break;
                case BookOptionEnum.Category:
                    books = _db.Categories.Find(categoryId).Books.ToList();
                    break;
                case BookOptionEnum.Favorite:
                    books = await _db.Interactions.Where(it => it.UserId == userId && it.IsLove)
                        .Select(it => it.Book).OrderByDescending(it => it.Name)
                        .ToListAsync();
                    break;
                case BookOptionEnum.Search:
                    books = await _db.Books.Where(bk => bk.Name.Contains(keywork) ||
                    (bk.Author.LastName + " " + bk.Author.FirstName).Contains(keywork)).ToListAsync();
                    break;
                case BookOptionEnum.SearchAdvanced:
                    books = await _db.Books.Where(bk => bk.Name.Contains(advModel.BookName) && (bk.Author.LastName + " " + bk.Author.FirstName).Contains(advModel.AuthorName) &&
                     bk.CategoryId == advModel.CategoryId && bk.LanguageId == advModel.LanguageId).ToListAsync();
                    break;
                default: 
                    books = null;
                    break;
            }
            if (!isPaging)
                return View(viewName: "Default", books);
            else
                return View(viewName: "Paging", books);
        }
    }
}
