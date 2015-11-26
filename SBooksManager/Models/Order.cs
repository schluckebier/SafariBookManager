using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SBooksManager.Models
{
    public class Order
    {
        public int OrderID { get; set; }



        public string CustomerEmail { get; set; }
        [ForeignKey("CustomerEmail")]

        public virtual Customer Customer { get; set; }

        public int SKU { get; set; }
        [ForeignKey("SKU")]
        public virtual Book Book { get; set; }

        public string CouponID { get; set; }
        [ForeignKey("CouponID")]
        public virtual Coupon Coupon { get; set; }

        public virtual List<Book> Books { get; set; }

    }
}