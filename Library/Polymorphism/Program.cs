using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal human = new Human();
            human.Eat();
            Console.WriteLine("Human weight: " + human.Weight);

            Animal cat = new Cat();
            cat.Eat();
            Console.WriteLine("Cat weight: " + cat.Weight);

            Animal dog = new Dog();
            dog.Eat();
            Console.WriteLine("Dog weight: " + dog.Weight);
            Console.ReadKey();
        }
    }
}
