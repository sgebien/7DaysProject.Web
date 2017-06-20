using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace _7DaysProject.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Enter First Name")]
        public string Firstname { get; set; }
        [StringLength(5,ErrorMessage = "Last Name length should not be greater than 5")]
        public string Lastname { get; set; }
        public int Salary { get; set; }    

    }
}