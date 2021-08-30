using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLibrary.Areas.Reader.Data
{
    public class Interaction
    {
        [MaxLength(150)]
        public string UserId { get; set; }
        [MaxLength(150)]
        public string BookId { get; set; }
        public bool IsLove { get; set; }
        [Range(1,5)]
        public short Evaluation { get; set; }
        [MaxLength(500)]
        public string Comment { get; set; }
        [ForeignKey("BookId")]
        public virtual Book Book { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
