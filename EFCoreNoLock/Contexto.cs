using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EFCoreNoLock
{
    public class Contexto : DbContext
    {
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Orders> Orders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conexao = new SqlConnectionStringBuilder()
            {
                DataSource = "(local)",
                InitialCatalog = "NorthWind",
                IntegratedSecurity = true
            };
            //optionsBuilder.UseLazyLoadingProxies(true);
            optionsBuilder.UseSqlServer(conexao.ConnectionString);
        }
    }
}
