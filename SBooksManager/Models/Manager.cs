using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SBooksManager.Models
{
    public class Manager : Employee
    {
        public string ManagerID { get; set; }

        [Required]
        [EmailAddress]
        public string ManEmail { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string ManFName { get; set; }

        [Display(Name = "MI")]
        public string ManMI { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string ManLName { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string ManPassword { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string ManAddress { get; set; }

        [Required]
        [Display(Name = "ZipCode")]
        public string ManZipCode { get; set; }

        [Required]
        [Display(Name = "Phone")]
        [PhoneAttribute]
        public string ManPhone { get; set; }


        public bool ManActive { get; set; }

    }
}