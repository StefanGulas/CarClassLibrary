using CarClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car("Suzuki", "Jango", 9500);
            Car d = new Car("Ford", "Mustang", 92000);
            Console.WriteLine("Car c is as follows " + c.Make + ", " + c.Model + ", " + c.Price);
            Console.WriteLine("Car d is as follows " + d.Make + ", " + d.Model + ", " + d.Price);

            Store store = new Store();

            store.ShoppingList.Add(c);
            store.ShoppingList.Add(d);

            decimal total = store.Checkout();

            Console.WriteLine("Your total store value is " + total);
            


            Console.ReadKey();
        }
    }
}
