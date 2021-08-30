using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLibrary.Areas.Reader.Models.Book
{
    public class BookModel
    {
        [DisplayName("Book's Name")]
        [Required]
        public string Name { get; set; }
        [DisplayName("Upload book file")]
        [Required]
        public IFormFile Path { get; set; }
        [DisplayName("About book")]
        [Required]
        public string AboutBook { get; set; }
        [DisplayName("Reviews")]
        [Required]
        public string Reviews { get; set; }
        [DisplayName("Author")]
        [Required]
        public string Author { get; set; }
        [Required]
        [DisplayName("Price")]
        [Range(0, 99999)]
        public decimal Price { get; set; }
        [DisplayName("Category")]
        [Required]
        public string CategoryId { get; set; }
        [DisplayName("Language")]
        [Required]
        public string LanguageId { get; set; }
    }
}
