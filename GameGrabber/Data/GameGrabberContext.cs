using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GameGrabber.Models;

namespace GameGrabber.Data
{
    public class GameGrabberContext : DbContext
    {
        public GameGrabberContext (DbContextOptions<GameGrabberContext> options)
            : base(options)
        {
        }

        public DbSet<GameGrabber.Models.Customer> Customers { get; set; }

        public DbSet<GameGrabber.Models.Product> Product { get; set; }

        public DbSet<GameGrabber.Models.Employee> Employee { get; set; }
        public DbSet<GameGrabber.Models.Sales> Sales { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Sales>().ToTable("Sales");
        }
        
    }
}
