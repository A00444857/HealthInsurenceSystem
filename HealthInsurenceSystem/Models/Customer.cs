using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace HealthInsurenceSystem.Models
{
    public partial class Customer
    {
        
        public string Cemail { get; set; }
        [Key]
        public int Pnumber { get; set; }
        public string Aemail { get; set; }
        public DateTime Duedate { get; set; }
        public int Amount { get; set; }
        public DateTime? Lastpayment { get; set; }
    }
}
