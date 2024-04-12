using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain
{
    public class BookOrdered
    {
        public int BookId { get; }
        public int NumberOrdered { get; }

        public BookOrdered(int bookId, int numberOrdered)
        {
            BookId = bookId;
            NumberOrdered = numberOrdered;
        }
    }
}
