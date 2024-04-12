using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Dog : Animal
    {
        internal Dog()
        {
            Weight = 25;
            Meal = 2;
        }

        public override void Eat()
        {
            Weight += Meal / 2;
        }
    }
}
