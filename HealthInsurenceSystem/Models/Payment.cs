using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace HealthInsurenceSystem.Models
{
    public partial class Payment
    {
        [Key]
        [StringLength(16, ErrorMessage = "Check Card Number")]
        public string Cardnumber { get; set; }
        
        public int Cvv { get; set; }
        [StringLength(5, ErrorMessage = "Check Date")]
        public string ExpiredDate { get; set; }
    }
}
