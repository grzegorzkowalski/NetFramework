using ConsoleApp;
using ConsoleApp.Services;
using Library.Persistence;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

namespace Library.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inheritance of Interfaces
            List<ICar> cars = new List<ICar>();
            Car car = new Car();
            Truck truck = new Truck();
            cars.Add(car);
            cars.Add(truck);

            var generic = new GenericClass<int>();
            generic.AddValues(1);
            generic.AddValues(2);
            generic.AddValues(3);
            generic.PrintValues(1);

            var stringGeneric = new GenericClass<string>();
            stringGeneric.AddValues("John");
            stringGeneric.AddValues("Doe");
            stringGeneric.AddValues("Smith");
            stringGeneric.PrintValues("Kowal");

            Console.WriteLine("Write username");
            string username = Console.ReadLine();
            Console.WriteLine("Write password");
            string password = Console.ReadLine();
            var repository = new BooksRepository();
            var instanceOfBookService = new BooksService(repository);
            var orderRepository = new OrdersRepository();
            var instanceOfOrderService = new OrderService(orderRepository);
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
                            instanceOfOrderService.PlaceOrder();
                            break;
                        case "list of orders":
                            instanceOfOrderService.ListAll();
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
