using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLibrary.Areas.Reader.Models.Home
{
    public class RegisterAuthorModel
    {
        [DisplayName("Backup Email")]
        [DataType(DataType.EmailAddress)]
        [Required]
        public string BackupEmail { get; set; }
        [DisplayName("Phone")]
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        [DisplayName("About Author")]
        public string AboutAuthor { get; set; }
    }
}
