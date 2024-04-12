using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var user = new User();
            //user.Name = "John";
            //user.Surname = "Doe";
            //user.SayHello();
            //StaticUser.SayHello();
            //user.Name = "Terminator";
            //user.Surname = "T-800";
            //user.SayHello();
            //// Calculate the volume of a sphere - Task 4
            //double r, volume;
            //Console.WriteLine("Enter the radius of the sphere: ");
            //r = Convert.ToDouble(Console.ReadLine());
            //volume = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);
            //Console.WriteLine("The volume of the sphere is: " + volume);

            //// Check is it Pythagorean triangle - Task 5
            //int a, b, c;
            //Console.WriteLine("Enter the first side of the triangle: ");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the second side of the triangle: ");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the third side of the triangle: ");
            //c = Convert.ToInt32(Console.ReadLine());
            //if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
            //{
            //    Console.WriteLine("The triangle is Pythagorean.");
            //}
            //else
            //{
            //    Console.WriteLine("The triangle is not Pythagorean.");
            //}
            //Console.ReadLine();

            // Create 8 variables of different types - Operators Task 1
            int number = 5;
            float test = 5;
            float money = 5.5f;
            string text = "John";
            char myChar = 'A';
            bool isLogged = true;
            decimal price = 5.55555m;
            decimal price2 = Decimal.Round(price, 2);
            Console.WriteLine("Price2: " + price2);
            Console.WriteLine("Number: " + number);
            Console.WriteLine("Money: " + money);
            Console.WriteLine("Text: " + text);
            Console.WriteLine("Char: " + myChar);
            Console.WriteLine("IsLogged: " + isLogged);
            Console.WriteLine("Price: " + price);
            Console.ReadLine();



        }
    }
}
