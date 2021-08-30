using System;
using System.Collections.Generic;
using CoreLibrary.Data;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CoreLibrary.Areas.Reader.Data;

namespace CoreLibrary.Data
{
    public class Country
    {
        [MaxLength(150)]
        public string Id { get; set; }
        [MaxLength(200)]
        [Required]
        public string Name { get; set; }
        public virtual ICollection<User> IdentityUsers { get; set; }
    }
}
