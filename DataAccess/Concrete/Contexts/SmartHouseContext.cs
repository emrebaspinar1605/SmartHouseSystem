using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Contexts
{
    public class SmartHouseContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=SmartHouse;Trusted_Connection=true");
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ElectronicStuff> ElecktronicStuffs { get; set; }
        public DbSet<Product> Products  { get; set; }
    }
}
