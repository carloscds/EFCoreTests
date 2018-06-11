using System;
using Microsoft.EntityFrameworkCore;
using Ralms.EntityFrameworkCore.Extensions;
using System.Linq;

namespace EFCoreNoLock
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new Contexto();

            var cliente = db.Customers
                .WithNoLock()
                .ToList();

            foreach(var c in cliente)
            {
                Console.WriteLine(c.CompanyName);
            }
        }
    }
}
