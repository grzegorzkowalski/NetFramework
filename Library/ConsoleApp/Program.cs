using ConsoleApp.Services.ConsoleApp;
using Library.Domain;
using Library.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            BooksRepository booksRepository = new BooksRepository();
            Console.WriteLine("Write username");
            string username = Console.ReadLine();
            Console.WriteLine("Write password");
            string password = Console.ReadLine();
            if (username == "Admin" && password == "password")
            {
                Console.WriteLine("Access Granted");
                var command = "";
                while (!command.Equals("exit"))
                {
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1. Add");
                    Console.WriteLine("2. Delete");
                    Console.WriteLine("3  List");
                    Console.WriteLine("4. Change");
                    Console.WriteLine("5. Add order");
                    Console.WriteLine("6. List od orders");
                    Console.WriteLine("7. exit");
                    command = Console.ReadLine();
                    var instanceOfBookService = new BooksService();
                    switch (command)
                    {
                        case "dodaj":
                            instanceOfBookService.AddBook();
                            break;
                        case "usun":
                            instanceOfBookService.RemoveBook();
                            break;
                        case "wypisz":
                            instanceOfBookService.ListBooks();
                            break;
                        case "zmien":
                            instanceOfBookService.ChangeState();
                            break;
                        case "dodaj zamowienie":
                            orderService.PlaceOrder();
                            break;
                        case "lista zamowien":
                            orderService.ListAll();
                            break;
                        case "wyjdz":
                            continue;
                        case "default":
                            Console.WriteLine("błędna komenda");
                            break;
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("Access Denied");
            }
            Console.ReadLine();
        }
    }
}
