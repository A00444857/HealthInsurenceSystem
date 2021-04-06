using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace HealthInsurenceSystem.Models
{
    public partial class Policy
    {
        [Key]
        public int? Pnumber { get; set; }
        public int? MinAge { get; set; }
        public int? MaxAge { get; set; }
        public int? MonthPremium { get; set; }
        public int? Duration { get; set; }
    }
}
