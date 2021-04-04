using System;
using System.Collections.Generic;

#nullable disable

namespace HealthInsurenceSystem.Models
{
    public partial class Admin
    {
        public string AdminEmail { get; set; }
        public int? Pnumber { get; set; }
        public int? Action { get; set; }
    }
}
