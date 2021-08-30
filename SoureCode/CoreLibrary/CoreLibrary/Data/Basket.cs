using CoreLibrary.Areas.Reader.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLibrary.Data
{
    public class Basket
    {
        public string UserId { get; set; }
        public string BookId { get; set; }
        [Range(0,99999)]
        public decimal Price { get; set; }
        [MaxLength(500)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime DateTimePaymented { get; set; } = DateTime.Now;
        [ForeignKey("BookId")]
        public virtual Book Book { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
