using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLibrary.Areas.Reader.Models.Author
{
    public class BookDetailModel
    {
        public string Id { get; set; }
        [Required, DisplayName("Name")]
        public string Name { get; set; }
        [Required, DisplayName("Language")]
        public string LanguageId { get; set; }
        [Required, DisplayName("Category")]
        public string CategoryId { get; set; }
        [Required, DisplayName("Price"), Range(0,99999)]
        public decimal Price { get; set; }
        [Required, DisplayName("Reduce Price"), Range(-1, 99999)]
        public decimal ReducePrice { get; set; }
        [Required, DisplayName("About book"), DataType(DataType.MultilineText)]
        public string AboutBook { get; set; }
        [Required, DisplayName("Review"), DataType(DataType.MultilineText)]
        public string Review { get; set; }
        public int Sold { get; set; }
        public decimal Sales { get; set; }


    }
}
