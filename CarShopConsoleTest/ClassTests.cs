using System;
using System.Linq;
using System.Threading;
using CarClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarShopConsoleTest
{
    [TestClass]
    public class ClassTests
    {
        [TestMethod]
        public void CarClassTest()
        {
            //Arrange
            Car car = new Car();
            string Make = "BMW";
            string Model = "3er";
            decimal Price = 34500M;

            //Act
            car.Make = "BMW";
            car.Model = "3er";
            car.Price = 34500M;

            //Assert
            Assert.AreEqual(Make, car.Make);
            Assert.AreEqual(Model, car.Model);
            Assert.AreEqual(Price, car.Price);
        }
        [TestMethod]
        public void StoreClassTest()
        {
            //Arrange
            Store store = new Store();

            Car car = new Car();
            string Make = "BMW";
            string Model = "3er";
            decimal Price = 34500M;

            //Act
            car.Make = "BMW";
            car.Model = "3er";
            car.Price = 34500M;
            store.CarList.Add(car);

            //Assert
            Assert.AreEqual(Make, store.CarList[0].Make);
            Assert.AreEqual(Model, store.CarList[0].Model);
            Assert.AreEqual(Price, store.CarList[0].Price);
        }

        [TestMethod]
        public void ClassTest()
        {
            //Arrange
            Store store = new Store();
            Car car1 = new Car();
            Car car2 = new Car();
            string Make = "BMW";
            string Model = "3er";
            decimal Price = 34500M;

            string Make2 = "VW";
            string Model2 = "Golf";
            decimal Price2 = 22400M;
            //Act
            car1.Make = "BMW";
            car1.Model = "3er";
            car1.Price = 34500M;
            car2.Make = "VW";
            car2.Model = "Golf";
            car2.Price = 22400M;
            store.CarList.Add(car1);
            store.CarList.Add(car2);

            //Assert
            Assert.AreEqual(Make, store.CarList[0].Make);
            Assert.AreEqual(Model2, store.CarList[1].Model);
            Assert.AreEqual(Price2, store.CarList[1].Price);
            Assert.AreEqual(Price, store.CarList[0].Price);
        }
        [TestMethod]
        public void MethodTest()
        {
            //Arrange
            Store store = new Store();
            Car car1 = new Car();
            Car car2 = new Car();
            string Make = "BMW";
            string Model = "3er";
            decimal Price = 34500M;

            string Make2 = "VW";
            string Model2 = "Golf";
            decimal Price2 = 22400M;
            car1.Make = "BMW";
            car1.Model = "3er";
            car1.Price = 34500M;
            car2.Make = "VW";
            car2.Model = "Golf";
            car2.Price = 22400M;

            decimal expectedTotal = car1.Price + (2 * car2.Price);
            int expectedCount = 0;
            //Act
            store.CarList.Add(car1);
            store.CarList.Add(car2);

            store.ShoppingList.Add(car1);
            store.ShoppingList.Add(car2);
            store.ShoppingList.Add(car2);

            var actualTotal = store.Checkout();
            var actualCount = store.ShoppingList.Count();

            //Assert
            Assert.AreEqual(expectedTotal, actualTotal);
            Assert.AreEqual(expectedCount, actualCount);
        }

    }
}
