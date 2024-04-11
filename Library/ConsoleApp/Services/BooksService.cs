using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Services
{
    internal class BooksService
    {
        internal BooksService()
        {
        }
        internal void AddBook()
        {
            Console.WriteLine("Add Title");
            var title = Console.ReadLine();
            Console.WriteLine("Add author");
            var author = Console.ReadLine();
            Console.WriteLine("Add publication date");
            var publicationYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add isbn");
            var isbn = Console.ReadLine();
            Console.WriteLine("Add products available");
            var productsAvailable = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add price");
            var price = Convert.ToDecimal(Console.ReadLine());              
        }

        internal void RemoveBook()
        {
            Console.WriteLine("Add title which you want to delete?");
            var title = Console.ReadLine();
        }

        internal void ListBooks()
        {
            Console.WriteLine("The list of books will apear here.");
        }

        internal void ChangeState()
        {
            Console.WriteLine("Add the title ypu want to update?");
            var title = Console.ReadLine();
            Console.WriteLine("Add value");
            var productsAvailable = Convert.ToInt32(Console.ReadLine());
        }

    }
}
