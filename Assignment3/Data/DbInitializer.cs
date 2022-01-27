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
        }
    }
}