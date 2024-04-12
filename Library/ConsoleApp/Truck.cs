using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Truck : ICar
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int NumberOfTyres { get; set; }
        public string TypeOfWagon { get; set; }

        public void AddCar()
        {
            Console.WriteLine("Add Brand");
            Brand = Console.ReadLine();
            Console.WriteLine("Add Model");
            Model = Console.ReadLine();
            Console.WriteLine("Add Year");
            Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add Color");
            Color = Console.ReadLine();
            Console.WriteLine("Add Price");
            Price = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Add Quantity");
            Quantity = Convert.ToInt32(Console.ReadLine());
        }

        public void RemoveCar()
        {
            Console.WriteLine("Add Brand which you want to delete?");
            Brand = Console.ReadLine();
        }

        public void ListCars()
        {
            Console.WriteLine("The list of cars will apear here.");
        }

        public void ChangeState()
        {
            Console.WriteLine("Add the Brand you want to update?");
            Brand = Console.ReadLine();
            Console.WriteLine("Add value");
            Quantity = Convert.ToInt32(Console.ReadLine());
        }
    }
}
