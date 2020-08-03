using CarClassLibrary;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            
            
            Console.WriteLine("Welcome to the car store. First you must create some car inventory. Then you may add some cars to the shopping cart. Finally you may checkout wich will give you a total value of the shopping cart.");

            int action = chooseAction();

            while (action != 0)
            {
                switch (action)
                {
                    // Add to inventory
                    case 1:
                        Console.WriteLine("OK, you want to add a car to your inventory.");
                        string carMake = "";
                        string carModel = "";
                        decimal carPrice = 10000M;

                        Console.WriteLine("What is the Brand you want to choose?");
                        carMake = Console.ReadLine();

                        Console.WriteLine("What is the Model you want to choose?");
                        carModel = Console.ReadLine();

                        Console.WriteLine("What is the price of the car?");
                        carPrice = int.Parse(Console.ReadLine());

                        Car newCar = new Car(carMake, carModel, carPrice);
                        store.CarList.Add(newCar);

                        printInventory(store, store.CarList);

                        break;

                    // Add to cart    
                    case 2:
                        printInventory(store, store.CarList);

                        Console.WriteLine("Which car do you want to add to your cart?");

                        string chosenLine = Console.ReadLine();

                        int chosenCar = int.Parse(chosenLine);

                        store.ShoppingList.Add(store.CarList[chosenCar - 1]);

                        Console.WriteLine("These are the cars in your cart:");

                        printInventory(store, store.ShoppingList);

                        break;


                    // Checkout Add Prices to get a total
                    case 3:

                        Console.WriteLine("The cars you chose are:");

                        printInventory(store, store.ShoppingList);

                        decimal total = store.Checkout();
                        
                        Console.WriteLine("The total value of the cars in you cart is: " + total.ToString());

                        break;

                    default:
                        break;
                }

                action = chooseAction();
            }

            
        }

        private static void printInventory(Store store, List<Car> list)
        {
            var listOfCars = list;
            int count = 1;
            foreach (var c in listOfCars)
            {
                Console.WriteLine("Car No. " + count.ToString() + ": " + c.Make + " " + c.Model + " " + c.Price);
                count++;
            }
        }

        static public int chooseAction()
        {
            int choice = 0;
            bool continueLoop = true;
            while (continueLoop)
            {
                Console.WriteLine("Choose an action: (0) to quit (1) to add a new car to inventory (2) add a car to your cart (3) to check out");
                bool isCorrectChoice = Int32.TryParse(Console.ReadLine().ToString(), out choice);
                if (!((choice == 0 && isCorrectChoice) || choice == 1 || choice == 2 || choice == 3))
                {
                    Console.WriteLine(choice + " is not a valid input try again");
                }
                else continueLoop = false;
            }
            return choice;

            }
    }
}
