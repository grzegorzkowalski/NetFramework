﻿using Library.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Persistence
{
    public class BooksRepository
    {
        public readonly List<Book> _database = new List<Book>() 
        {
            new Book("The Old Man and the Sea", "Ernest Hemingway", 1952, "AAAA", 10, 19.99m),
            new Book("For Whom the Bell Tolls", "Ernest Hemingway", 1940, "BBBB", 0, 119.99m),
            new Book("Alice in Wonderland", "C.K. Lewis", 1865, "CCCC", 53, 39.99m),
            new Book("The Chronicles of Narnia", "C.K. Lewis", 1949, "DDDD", 33, 49.99m),
            new Book("Harry Potter", "J.K. Rowling", 1997, "EEEE", 23, 69.99m),
            new Book("Catch-22", "Joseph Heller", 1961, "FFFF", 5, 45.99m),
            new Book("The Doll", "Bolesław Prus", 1889, "GGGG", 7, 76.99m),
            new Book("It", "Stephen King", 1986, "HHHH", 2, 12.99m),
            new Book("The Idiot", "Fyodor Dostoevsky", 1869, "IIII", 89, 25.99m),
            new Book("The Master and Margarita", "Mikhail Bulgakov", 1967, "JJJJ", 41, 36.99m),
        };

        public void Insert(Book book)
        {
            _database.Add(book);
        }      

        public void RemoveByTitle(Book book) 
        {
            var bookToRemove = _database.FirstOrDefault(b => b.Title == book.Title);
            if (bookToRemove != null)
            {
                _database.Remove(bookToRemove);
            }
        }

        public List<Book> GetAll()
        {
            return _database;
        }

        public void ChangeState(string title, int stateChange)
        {
            var book = _database.FirstOrDefault(b => b.Title == title);
            if (book != null)
            {
                book.ProductsAvailable += stateChange;
            }
        }

    }
}
