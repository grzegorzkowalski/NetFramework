using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain
{
    public class Order
    {
        public DateTime Date { get; set; }
        public List<BookOrdered> BooksOrderedList { get; set; }

        public Order()
        {
            Date = DateTime.Now;
            BooksOrderedList = new List<BookOrdered>();
        }

        public override string ToString()
        {
            string text = "";
            text += $"Order: {Date}" + Environment.NewLine;
            foreach (var item in BooksOrderedList)
            {
                text += $"Book {item.BookId} BooksOrdered: {item.NumberOrdered} {Environment.NewLine}";
            }
            return text; 
        }
    }
}
