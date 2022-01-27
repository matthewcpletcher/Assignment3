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
        public DbSet<Assignment3.Models.OrderItem> OrderItems { get; set; }
        public DbSet<Assignment3.Models.Payment> Payments { get; set; }
        public DbSet<Assignment3.Models.Store> Stores { get; set; }
        public DbSet<Assignment3.Models.Cart> Carts {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>();
            modelBuilder.Entity<Order>();
            modelBuilder.Entity<OrderItem>();
            modelBuilder.Entity<DeliveryPerson>();
            modelBuilder.Entity<Payment>().HasNoKey();
            modelBuilder.Entity<Store>();
            modelBuilder.Entity<Cart>();
        }
    }
}
