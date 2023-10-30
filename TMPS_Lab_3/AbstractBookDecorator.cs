using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_Lab_3
{
    // Decorator Pattern: Base Decorator
    abstract class AbstractBookDecorator : Book
    {
        protected Book _book;

        public AbstractBookDecorator(Book book) : base(book.Title, book.Author)
        {
            _book = book;
        }

        public override void Issue() { _book.Issue(); }
        public override void Return() { _book.Return(); }
    }
}
