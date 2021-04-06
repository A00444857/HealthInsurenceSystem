using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace HealthInsurenceSystem.Models
{
    public partial class Payment
    {
        [Key]
        public int Cardnumber { get; set; }
        public int Cvv { get; set; }
        public string ExpiredDate { get; set; }
    }
}
