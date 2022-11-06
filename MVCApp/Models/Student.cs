using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please Enter your name"),MinLength(6)]
        [Display(Name ="Student Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter your Age")]
        public int Age { get; set; }


        [Required(ErrorMessage = "Please Enter your RegNo")]
        [Display(Name="Registraion No")]
        public string RegNo { get; set; }

        [Required(ErrorMessage = "Please Enter your Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter your Department")]
        [Display(Name="Department Name")]
        public string Department { get; set; }

    }
}