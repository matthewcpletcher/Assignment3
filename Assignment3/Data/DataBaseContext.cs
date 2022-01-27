#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment3.Models;

namespace Assignment3.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext (DbContextOptions<DataBaseContext> options)
            : base(options)
        {
        }
        
        public DbSet<Assignment3.Models.Customer> Customers { get; set; }
        public DbSet<Assignment3.Models.DeliveryPerson> DeliveryPeople { get; set;}
        public DbSet<Assignment3.Models.Order> Orders { get; set; }
        public DbSet<Assignment3.Models.OrderItems> OrderItems { get; set; }
        public DbSet<Assignment3.Models.Payment> Payments { get; set; }
        public DbSet<Assignment3.Models.Store> Stores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>();
            modelBuilder.Entity<Order>();
            modelBuilder.Entity<OrderItems>();
            modelBuilder.Entity<DeliveryPerson>();
            modelBuilder.Entity<Payment>();
            modelBuilder.Entity<Store>();
        }
    }
}
