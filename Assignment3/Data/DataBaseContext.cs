#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment3.Models;
using Microsoft.EntityFrameworkCore.InMemory;

namespace Assignment3.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext (DbContextOptions<DataBaseContext> options)
            : base(options)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DbContext>()
            .UseInMemoryDatabase("InMemoryDb");

            using (var db = new DbContext(optionsBuilder.Options))
            {
                // Use the db here in the unit test.
            }
        }
        public static DbContextOptions<DbContext> TestDbContextOptions()
            {
            // Create a new service provider to create a new in-memory database.
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkInMemoryDatabase()
                .BuildServiceProvider();

            // Create a new options instance using an in-memory database and 
            // IServiceProvider that the context should resolve all of its 
            // services from.
            var builder = new DbContextOptionsBuilder<DbContext>()
            .UseInMemoryDatabase("InMemoryDb")
            .UseInternalServiceProvider(serviceProvider);

            return builder.Options;
        }
        public DbSet<Assignment3.Models.Customer> Customers { get; set; }
        public DbSet<Assignment3.Models.DeliveryPerson> DeliveryPeople { get; set;}
        public DbSet<Assignment3.Models.Order> Orders { get; set; }
        public DbSet<Assignment3.Models.OrderItem> OrderItems { get; set; }
        public DbSet<Assignment3.Models.Payment> Payments { get; set; }
        public DbSet<Assignment3.Models.Store> Stores { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>();
            modelBuilder.Entity<Order>();
            modelBuilder.Entity<OrderItem>();
            modelBuilder.Entity<DeliveryPerson>();
            modelBuilder.Entity<Payment>().HasNoKey();
            modelBuilder.Entity<Store>();
        }


        public async Task Test1()
        {
            using (var db = new DbContext(TestDbContextOptions()))
            {
                var recId = 1;
                var expectedCustomers =
                    Customers.Where(Customer => Customer.CustomerID == recId).ToList();
            }
        }
    }
}
