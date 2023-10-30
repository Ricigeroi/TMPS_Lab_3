using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_Lab_3
{
    // Composite Pattern
    class BookCollection : Book
    {
        private List<Book> _books = new List<Book>();

        public BookCollection(string title) : base(title, "Collection") { }

        public void Add(Book book) { _books.Add(book); }

        public override void Issue()
        {
            Console.WriteLine($"Issuing book collection: {Title}");
            foreach (var book in _books) book.Issue();
        }

        public override void Return()
        {
            Console.WriteLine($"Returning book collection: {Title}");
            foreach (var book in _books) book.Return();
        }
    }
}
