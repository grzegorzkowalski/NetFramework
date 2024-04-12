using Library.Domain;
using Library.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Services
{
    internal class OrderService
    {
        private OrdersRepository _repository;
        public OrderService(OrdersRepository repository)
        {
            _repository = repository;
        }

        public void PlaceOrder()
        {
            Order order = new Order();
            var str = "";
            while (!str.Equals("end"))
            {
                Console.WriteLine("add - add position to the order");
                Console.WriteLine("end - close order");
                str = Console.ReadLine();
                switch (str)
                {
                    case "add":
                        Console.WriteLine("Book id");
                        var id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("How many do you want to order?");
                        var count = Convert.ToInt32(Console.ReadLine());
                        BookOrdered bookOrdered = new BookOrdered();
                        bookOrdered.BookId = id;
                        bookOrdered.NumberOrdered = count;
                        order.BooksOrderedList.Add(bookOrdered);
                        break;
                    case "end":
                        _repository.Insert(order);
                        break;
                    default:
                        break;
                }
            }
        }

        public void ListAll()
        {
            foreach (var item in _repository.GetAll())
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

}
