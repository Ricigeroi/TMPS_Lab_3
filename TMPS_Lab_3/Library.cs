using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_Lab_3
{
    class Library
    {
        private List<Book> _books = new List<Book>();

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void IssueBook(Book book) { book.Issue(); }
        public void ReturnBook(Book book) { book.Return(); }

        public void ListAllBooks()
        {
            Console.WriteLine("Listing all books in the library:");
            foreach (var book in _books)
                Console.WriteLine($"- {book.Title} by {book.Author}");
        }
    }
}
