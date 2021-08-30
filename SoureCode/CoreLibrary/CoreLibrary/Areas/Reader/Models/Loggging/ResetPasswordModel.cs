using CoreLibrary.Helper.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLibrary.Areas.Reader.Models
{
    public class ResetPasswordModel
    {
        public TokenPackageModel TokenPackage { get; set; }
        [DataType(DataType.Password)]
        [Required]
        [DisplayName("Password")]
        [PatternText]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [DisplayName("Confirm Password")]
        [Compare("Password")]
        [Required]
        public string ConfirmPassword { get; set; }
        public bool IsSignInNow { get; set; }
    }
}
