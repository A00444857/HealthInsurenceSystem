using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


#nullable disable

namespace HealthInsurenceSystem.Models
{
    public partial class Admin
    {
        [Key]
        public string AdminEmail { get; set; }
        public int? Pnumber { get; set; }
        public int? Action { get; set; }
    }
}
