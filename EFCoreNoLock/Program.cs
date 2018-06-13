using System;
using System.Linq;

namespace EFCoreNoLock
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new Contexto();

            var cliente = db.Customers
                .ToList();

            foreach(var c in cliente)
            {
                Console.WriteLine(c.CompanyName);
                foreach(var o in c.Orders)
                {
                    Console.WriteLine($"Order: {o.OrderID}");
                }
            }
        }
    }
}
