using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLibrary.Areas.Reader.Data
{
    public class Language
    {
        [MaxLength(150)]
        public string Id { get; set; }
        [Required, MaxLength(150)]
        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
