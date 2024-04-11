using ConsoleApp.Services;
using Library.Persistence;
using System;

namespace Library.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write username");
            string username = Console.ReadLine();
            Console.WriteLine("Write password");
            string password = Console.ReadLine();
            var repository = new BooksRepository();
            var instanceOfBookService = new BooksService(repository);
            if (username == "Admin" && password == "password")
            {
                Console.WriteLine("Access Granted");
                var command = "";
                while (!command.Equals("exit"))
                {
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1. add");
                    Console.WriteLine("2. delete");
                    Console.WriteLine("3  list");
                    Console.WriteLine("4. change");
                    Console.WriteLine("5. add order");
                    Console.WriteLine("6. list of orders");
                    Console.WriteLine("7. exit");
                    command = Console.ReadLine();
                    switch (command)
                    {
                        case "add":
                            instanceOfBookService.AddBook();
                            break;
                        case "delete":
                            instanceOfBookService.RemoveBook();
                            break;
                        case "list":
                            instanceOfBookService.ListBooks();
                            break;
                        case "change":
                            instanceOfBookService.ChangeState();
                            break;
                        case "add order":
                            Console.WriteLine("trying to add a new order");
                            break;
                        case "list of orders":
                            Console.WriteLine("trying to list all orders");
                            break;
                        case "exit":
                            break;
                        case "default":
                            Console.WriteLine("błędna komenda");
                            break;
                    }
                    Console.WriteLine(!command.Equals("exit") ? "Press any key to continue" : "Press any key to close");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("Access Denied");
                Console.WriteLine("Press any key to close");
                Console.ReadKey();
            }      
        }
    }
}
