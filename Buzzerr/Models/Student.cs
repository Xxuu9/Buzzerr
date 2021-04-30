using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Buzzerr.Models
{
    public class Student
    {
        [Key]
        [HiddenInput]
        public int StudentID { get; set; }

        [Required]
        public String FirstName { get; set; }

        [Required]
        public String LastName { get; set; }

        [EmailAddress]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+(@utoronto\.ca|@uwo\.ca|@yorku.ca)$", ErrorMessage = "Registration limited to utoronto.ca, uwo.ca and yorku.ca.")]
        [Required]
        public string UserEmail { get; set; }

        [DataType(DataType.Password)]
        public String Password { get; set; }


    }
}
