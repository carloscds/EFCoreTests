using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreNoLock
{
    public class Customers
    {
        [Key]
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public virtual IEnumerable<Orders> Orders { get; set; }
        public Customers()
        {
            Orders = new List<Orders>();
        }
    }
}
