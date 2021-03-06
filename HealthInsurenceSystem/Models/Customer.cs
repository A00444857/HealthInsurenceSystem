using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace HealthInsurenceSystem.Models
{
    public partial class Customer
    {
        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Cemail { get; set; }
        [Key]
        public int Pnumber { get; set; }
        public string Aemail { get; set; }
        public DateTime Purchaseddate { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public int Amount { get; set; }
        public int Duration { get; set; }
        public string Ptype { get; set; }
        public DateTime? Lastpayment { get; set; }

    }
}
