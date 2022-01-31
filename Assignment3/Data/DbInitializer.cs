using Assignment3.Models;

namespace Assignment3.Data
{
    public class DbInitializer
    {
        public static void Initialize(DataBaseContext context)
        {
            if (context.Customers.Any())
            {
                return;
            }

            var Customers = new Customer[]
            {
                new Customer { Name ="Bob Dinkleburg", Address="123 Beast St", PhoneNum="806-445-1337", Email="Bob@yahoo.com"}
            };

            context.Customers.AddRange(Customers);
            context.SaveChanges();

            var Stores = new Store[]
            {
                new Store {  Address="3332 Epic Lane", StoreName="Healthy Store"}
            };

            context.Stores.AddRange(Stores);
            context.SaveChanges();

            var DeliveryPerson = new DeliveryPerson[]
            {
                new DeliveryPerson { Name="Chad Johnson",}
            };

            context.DeliveryPeople.AddRange(DeliveryPerson);
            context.SaveChanges();

            var OrderItems = new OrderItem[]
            {
                new OrderItem{ ProductName="Bread", Price=2.99M},
                new OrderItem{ ProductName="Milk", Price=3.99M},
                new OrderItem{ ProductName="Steaks", Price=24.99M},
                new OrderItem{ ProductName="Chicken Thighs", Price=14.99M},
                new OrderItem{ ProductName="Beef Patties", Price=17.99M},
                new OrderItem{ ProductName="Eggs", Price=12.99M},
                new OrderItem{ ProductName="Captain Crunch", Price=5.99M},
                new OrderItem{ ProductName="Soda", Price=2.99M}

            };

            context.OrderItems.AddRange(OrderItems);
            context.SaveChanges();
        }
    }
}