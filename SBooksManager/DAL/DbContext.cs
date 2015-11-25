using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SBooksManager.Models;

namespace SBooksManager.DAL {
    public class AppDbContext : DbContext { 
        
        //public DbSet<Customer> Customers { get; set; }
        //public DbSet<Employee> Employees { get; set; }
        //public DbSet<Book> Books { get; set; }

        public AppDbContext() : base("MyDBConnection") 
        { }

        public System.Data.Entity.DbSet<SBooksManager.Models.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<SBooksManager.Models.Coupon> Coupons { get; set; }

        public System.Data.Entity.DbSet<SBooksManager.Models.Promotion> Promotions { get; set; }

        public System.Data.Entity.DbSet<SBooksManager.Models.Book> Books { get; set; }

        //public System.Data.Entity.DbSet<SBooksManager.Models.Employee> Employees { get; set; }
    }
}