using Labb4_MVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb4_MVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Borrowing> Borrowings { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(new Book { BookId = 1, Title = "Tao enligt Puh", Author = "Benjamin Hoff" });
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 2, Title = "Björnstad", Author = "Fredrik Backman" });
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 3, Title = "Vi mot er", Author = "Fredrik Backman" });

            modelBuilder.Entity<Customer>().HasData(new Customer { CustomerId = 1, FirstName = "Robin", LastName = "Andersson", PhoneNumber = "4354213" });
            modelBuilder.Entity<Customer>().HasData(new Customer { CustomerId = 2, FirstName = "Johan", LastName = "Skoog", PhoneNumber = "4862569" });
            modelBuilder.Entity<Customer>().HasData(new Customer { CustomerId = 3, FirstName = "Signe", LastName = "Karlsson", PhoneNumber = "4872163" });
        }
    }
}
