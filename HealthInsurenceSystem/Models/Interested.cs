using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace HealthInsurenceSystem.Models
{
    public partial class Interested
    {
        [Key]
        public string Cemail { get; set; }
        public string Ptype { get; set; }
        public int Amount { get; set; }
    }
}
