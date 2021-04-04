using System;
using System.Collections.Generic;

#nullable disable

namespace HealthInsurenceSystem.Models
{
    public partial class Policy
    {
        public int? Pnumber { get; set; }
        public int? MinAge { get; set; }
        public int? MaxAge { get; set; }
        public int? MonthPremium { get; set; }
        public int? Duration { get; set; }
    }
}
