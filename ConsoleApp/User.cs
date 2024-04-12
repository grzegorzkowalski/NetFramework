using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class User
    {
        public string Name { get; set; }    
        public string Surname { get; set; }
        
        public void SayHello()
        {
            Console.WriteLine("Hello, " + Name + " " + Surname);
        }
    }
}
