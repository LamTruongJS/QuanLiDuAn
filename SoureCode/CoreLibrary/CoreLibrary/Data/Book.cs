using CoreLibrary.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLibrary.Areas.Reader.Data
{
    public class Book
    {
        [MaxLength(150)]
        public string Id { get; set; }

        [Required, MaxLength(150)]
        public string Name { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime DateTimePosted { get; set; } = DateTime.Now;
        [Required]
        public string PdfUrl { get; set; }
        [MaxLength(150)]
        public string ThumbnailUrl { get; set; }
        [Required, DataType(DataType.MultilineText)]
        public string AboutBook { get; set; }
        [Required, DataType(DataType.MultilineText)]
        public string Review { get; set; }
        [Range(-1,99999)]
        [Required]
        public decimal ReducedPrice { get; set; }
        [Required]
        [Range(0, 99999)]
        public decimal Price { get; set; }
        public long View { get; set; } = 0;
        //------------------------------------------------------//
        [MaxLength(150)]
        public string CategoryId { get; set; }
        [MaxLength(150)]
        public string LanguageId { get; set; }
        [MaxLength(150)]
        public string AuthorId { get; set; }
        //-------------------------------------------------------//

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        [ForeignKey("LanguageId")]
        public virtual Language Language { get; set; }
        [ForeignKey("AuthorId")]
        public virtual User Author { get; set; }
        public virtual ICollection<Basket> Baskets { get; set; }
        public virtual ICollection<Interaction> Interactions { get; set; }
    }
}
