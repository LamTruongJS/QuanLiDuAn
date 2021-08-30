using CoreLibrary.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLibrary.Areas.Reader.Data
{
    public class User : IdentityUser
    {
        [MaxLength(150)]
        public override string Id { get => base.Id; set => base.Id = value; }
        [MaxLength(100)]
        public string FirstName { get; set; }
        [MaxLength(100)]
        public string LastName { get; set; }
        [MaxLength(150)]
        public string CountryId { get; set; }
        public string AboutAuthor { get; set; }
        [MaxLength(50)]
        public string BankNumber { get; set; }
        [MaxLength(150)]
        public string BackupEmail { get; set; }
        [MaxLength(500)]
        public string Avatar { get; set; }
        [MaxLength(100)]
        public string HolderName { get; set; }
        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        public virtual ICollection<Basket> Baskets { get; set; }
        public virtual ICollection<Interaction> Interactions { get; set; }
    }
}
