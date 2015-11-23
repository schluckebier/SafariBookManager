using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SBooksManager.Models
{
    public class Customer
    {
        [Key]
        [Required]
        [Display(Name = "Email")]
        public string CustomerEmail { get; set; }

        [Required]
        public string FName { get; set; }

        public string MI { get; set; }

        [Required]
        public string LName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "the {0} must be at least {2} characters")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string StreetAddress { get; set; 

        [Required]
        public string City { get; set; }

        [Required]
        public string Zip { get; set; }

        [Required]
        public string CreditCard1 { get; set; }

        public string CreditCard1Type { get; set; }

        public string CreditCard2 { get; set; }

        public string CreditCard2Type { get; set; }

        public string CardType { get; set; }

        public bool CustomerActive { get; set; }

        public virtual List<Order> Orders { get; set; }

    }
}