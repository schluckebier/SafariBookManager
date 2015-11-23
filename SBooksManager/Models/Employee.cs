using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using SBooksManager.Models;

namespace SBooksManager.Models
{
    public class Employee
    {
        
        public string EmployeeID { get; set; }

        [Required]
        [EmailAddress]
        public string EmpEmail { get; set; }

        [Required]
        [Display(Name ="First Name")]
        public string EmpFName { get; set; }

        [Display(Name ="MI")]
        public string EmpMI { get; set; }
       
        [Required]
        [Display(Name = "Last Name")]
        public string EmpLName { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "ZipCode")]
        public string ZipCode { get; set; }

        [Required]
        [Display(Name = "Phone")]
        [PhoneAttribute]
        public string Phone { get; set; }


        public bool EmpActive {get; set;}
       

        public virtual List<Reorder> Reorders { get; set; }

    }
}