using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLibrary.Areas.Reader.Data
{
    public class News
    {
        public string ID { get; set; }
        [MaxLength(150), Required]
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime DateTimePosted { get; set; } = DateTime.Now;
        public string Cover { get; set; }
        
        public string AuthorID { get; set; }
        [ForeignKey("AuthorID")]
        public virtual User Author { get; set; }
    }
}
