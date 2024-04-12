using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain
{
    public class Book
    {
        public int ID { get; }
        public string Title { get; }
        public string Author { get; }
        public int PublicationYear { get; }
        public string ISBN { get; }

        public int ProductsAvailable { get; private set; }
        public decimal Price { get; }

        public Book() { }

        public Book(int id, string title, string author, int publicationYear, string isbn, int productsAvailable, decimal price)
        {
            ID = id;
            Title = title;
            Author = author;
            ISBN = isbn;
            PublicationYear = publicationYear;
            ProductsAvailable = productsAvailable;
            Price = price;
        }

        public override string ToString()
        {
            return $"Title: {Title} Author: {Author} ProductsAvailable: {ProductsAvailable}";
        }

        public void ChangeProductsAvailableNumber(int change) 
        { 
            ProductsAvailable += change;
        }
    }
}
