using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace frontend.Models
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions<MyAppDbContext> options): base(options) { }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer()
                {
                    Id = 1,
                    Name = "Microsoft",
                    VAT = "IE8256796U",
                    Enabled = true
                },
                new Customer()
                {
                    Id = 2,
                    Name = "Google",
                    VAT = "IE6388047V",
                    Enabled = false
                },
                new Customer()
                {
                    Id = 3,
                    Name = "Nagarro",
                    VAT = "IE6383047V",
                    Enabled = true
                },
                new Customer()
                {
                    Id = 4,
                    Name = "TCS",
                    VAT = "IE6333047V",
                    Enabled = false
                },
                new Customer()
                {
                    Id = 5,
                    Name = "IBM",
                    VAT = "IE6558047V",
                    Enabled = true
                },
                new Customer()
                {
                    Id = 6,
                    Name = "Tech Mahindra",
                    VAT = "IE9281047V",
                    Enabled = false
                });
        }
    }
}
