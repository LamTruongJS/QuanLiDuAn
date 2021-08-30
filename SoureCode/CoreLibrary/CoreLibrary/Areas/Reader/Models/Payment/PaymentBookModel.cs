using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLibrary.Areas.Reader.Models.Payment
{
    public class PaymentBookModel
    {
        [Required, DisplayName("Card holder's name")]
        public string CardHolderName { get; set; }
        [Required, DisplayName("Card numbers"), DataType(DataType.CreditCard)]
        public string CardNumber { get; set; }
        [Required, DisplayName("Remember card for next payment")]
        public bool IsRemember { get; set; }
        public string Author { get; set; }
        public string AvatarUrl { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Id { get; set; }
    }
}
