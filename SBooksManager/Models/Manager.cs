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
    }
}