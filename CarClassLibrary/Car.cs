using System;
using System.Xml.Schema;

namespace CarClassLibrary
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public Car()
        {
            Make = "nothing yet";
            Model = "nothing yet";
            Price = 0.00M;
        }
        public Car (string make, string model, decimal price)
        {
            Make = make;
            Model = model;
            Price = price;
        }

        public override string ToString()
        {
            return "Make: " + Make + " Model: " + Model + " Price: " + Price.ToString();
        }
    }
}
