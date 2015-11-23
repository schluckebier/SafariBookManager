using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace SBooksManager.Models
{
    public class Coupon
    {
        
        [Key]
        [Required]
        [Display(Name="Coupon Code")]
        //must be between 1 and 20 characters (letters and numbers)
        [StringLength(20, ErrorMessage = "the Coupon Code must be must be between 1 and 20 characters")]
        public string CouponID { get; set; }

         public enum CouponTypes { 
            [Description("Conditional Free Shpping")] 
            FreeShipIf, 
            [Description("Free Shipping Off All Orders")] 
            FreeShipAll,
            [Description("Apply Discount to Total")]
            DiscountTotal }; 
        
        [Required]
        //if free shipping, keep discount inactive
        //if discount, activate discount
        public CouponTypes CouponType { get; set; }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{

        //    if (CouponType == "DiscountTotal")
        //    {
        //        Discount.Enabled = true;

        //    }
        //}

        public decimal Discount { get; set; }

        public decimal OrderThreshold { get; set; }


    }

}