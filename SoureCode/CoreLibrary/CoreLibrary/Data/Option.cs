using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLibrary.Data
{
    public class Option
    {
        [MaxLength(150)]
        public string Id { get; set; }
        [Required, MaxLength(150)]
        public string Name { get; set; }
        [Required]
        public decimal Value { get; set; }
        [MaxLength(150)]
        public string Unit { get; set; }
        [Required]
        public bool IsApply { get; set; }
    }
}
