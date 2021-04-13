using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameGrabber.Data;
using GameGrabber.Models;




namespace GameGrabber.Data
{
    public static class DbInitializer
    {
        public static void Initialize(GameGrabberContext context)
        {
            context.Database.EnsureCreated();

             //Look for any Customers.
            if (context.Customers.Any())
            {
                return;   // DB has been seeded
            }

            var Customers = new Customer[]
            {
                new Customer{LastName="Eti", FirstMidName="Brooklyn", Address = "27d Sunshine drive", ItemPurchased = "PS4", PhoneNumber = 0212623205},
                new Customer{LastName="Sese", FirstMidName="Cyruss", Address = "45 Malcolm Street", ItemPurchased = "Xbox", PhoneNumber = 0217365489},
                new Customer{LastName="Shah", FirstMidName="Aryan", Address = "19 Your Dads Avenue", ItemPurchased = "Iphone 12", PhoneNumber = 0276543785}
            };

            context.Customers.AddRange(Customers);
            context.SaveChanges();

            //if (context.Employee.Any())
            //{
            //    return;   // DB has been seeded
            //}

            var Employees = new Employee[]
            {
                new Employee{EmployeeFirstName = "Davion", EmployeeLastName = "Tevi"},
                new Employee{EmployeeFirstName = "Jimi", EmployeeLastName = "Sipeli"}
                
            };

            context.Employee.AddRange(Employees);
            context.SaveChanges();
            
            /*if (context.Product.Any())
            {
                return;   // DB has been seeded
            }*/

            var Products = new Product[]
            {
                new Product{ProductName = "PS4", ProductPrice = "$400", Manufactur = "Sony"},
                new Product{ProductName = "Xbox", ProductPrice = "$399", Manufactur = "Microsoft"},
                new Product{ProductName = "Iphone12", ProductPrice = "$500", Manufactur = "Apple"}

            };

            context.Product.AddRange(Products);
            context.SaveChanges();

            /*if (context.Sales.Any())
            {
                return;   // DB has been seeded
            }*/

            var Sales = new Sales[]
            {
              new Sales{CustomersName = "Sophie", ProductsName = "Ps4"}
            };
        }
    }
}