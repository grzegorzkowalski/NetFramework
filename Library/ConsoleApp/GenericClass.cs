using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class GenericClass<T>
    {
        List<T> values = new List<T>();

        public void AddValues(T element)
        {
            values.Add(element);
        }
        
        public void PrintValues(T element)
        {
            Console.WriteLine(element.ToString()); ;
        }
    }
}
