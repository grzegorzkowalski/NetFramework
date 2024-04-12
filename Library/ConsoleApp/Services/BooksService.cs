using Library.Domain;
using Library.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Services
{
    internal class BooksService
    {
        private readonly BooksRepository _repository;
        internal BooksService(BooksRepository repository)
        {
            _repository = repository;
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
            var id = _repository.GetAll().Count + 1;
            _repository.Insert(new Book(id, title, author, publicationYear, isbn, productsAvailable, price));
        }

        internal void RemoveBook()
        {
            Console.WriteLine("Add title which you want to delete?");
            var title = Console.ReadLine();
            _repository.RemoveByTitle(new Book() { Title = title });
        }

        internal void ListBooks()
        {
            Console.WriteLine("The list of books will apear here.");
            var books = _repository.GetAll();
            foreach (var book in books)
            {
                Console.WriteLine($"ID: {book.ID} - {book.Title} - {book.Author} - {book.PublicationYear}");
            }
        }

        internal void ChangeState()
        {
            Console.WriteLine("Add the title you want to update?");
            var title = Console.ReadLine();
            Console.WriteLine("Add value");
            var productsAvailable = Convert.ToInt32(Console.ReadLine());
            _repository.ChangeState(title, productsAvailable);
        }

    }
}
