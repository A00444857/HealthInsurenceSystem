using System;
using System.Collections.Generic;

#nullable disable

namespace HealthInsurenceSystem.Models
{
    public partial class Customer
    {
        public string Cemail { get; set; }
        public int? Pnumber { get; set; }
        public string Aemail { get; set; }
        public DateTime? Dop { get; set; }
    }
}
