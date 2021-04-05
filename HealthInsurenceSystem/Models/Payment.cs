using System;
using System.Collections.Generic;

#nullable disable

namespace HealthInsurenceSystem.Models
{
    public partial class Payment
    {
        public int Cardnumber { get; set; }
        public int Cvv { get; set; }
        public string ExpiredDate { get; set; }
    }
}
