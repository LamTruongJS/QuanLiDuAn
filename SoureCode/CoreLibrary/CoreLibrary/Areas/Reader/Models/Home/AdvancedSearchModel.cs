using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLibrary.Areas.Reader.Models.Home
{
    public class AdvancedSearchModel
    {
        [DisplayName("Book's Name")]
        public string BookName { get; set; }
        [DisplayName("Author's Name")]
        public string AuthorName { get; set; }
        [DisplayName("Category")]
        public string CategoryId { get; set; }
        [DisplayName("Language")]
        public string LanguageId { get; set; }
        

    }
}
