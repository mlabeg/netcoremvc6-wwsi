using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain
{
    public class BookOrdered
    {
        public BookOrdered()
        {

        }
        public BookOrdered(int bookId, int numerOrdered)
        {
            BookId = bookId;
            NumerOrdered = numerOrdered;
        }

        public int BookId { get; }
        int NumerOrdered { get; set; }
    }
}
