using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace HealthInsurenceSystem.Models
{
    public partial class Person
    {

        [Key]
        public int Cnumber { get; set; }
        [Required(ErrorMessage = "Please enter your email")]
        [Display(Name = "Email address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email")]
        public string Email { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
       
        public string Password { get; set; }
    }
}
