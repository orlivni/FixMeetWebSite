using FixMeetWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FixMeetWeb.Data
{
    public static class DbInitializer
    {
        public static void Initialize(FixMeetContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Suppliers.Any())
            {
                return;   // DB has been seeded
            }

            var suppliers = new Supplier[]
            {
            new Supplier{FirstName="Otniel", LastName="Yazdi", Email="otniely@gmail.com", UserName="otniel", Password="123456789", Address="Bnei Brak", Category=Category.Transportation, Radius=5},
            new Supplier{FirstName="Ashot", LastName="Petrosian", Email="ashotp@gmail.com", UserName="ashotpetrosian", Password="1234567", Address="Netanya", Category=Category.Sport, Radius=3},
            new Supplier{FirstName="Yasmin", LastName="Tal", Email="yasmint@gmail.com", UserName="YasminTal", Password="123456", Address="Nahariya", Category=Category.Sport, Radius=6},
            new Supplier{FirstName="Or", LastName="Livni", Email="orl@gmail.com", UserName="orlivni", Password="1234", Address="Netanya", Category=Category.Food, Radius=8}
            };
            foreach (Supplier s in suppliers)
            {
                context.Suppliers.Add(s);
            }
            context.SaveChanges();

        }
    }
}
