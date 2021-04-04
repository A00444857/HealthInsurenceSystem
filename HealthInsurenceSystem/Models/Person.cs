using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace HealthInsurenceSystem.Models
{
    public partial class Person
    {
        [Key]
        
        public string Email { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public int Cnumber { get; set; }
        public string Password { get; set; }
    }
}
