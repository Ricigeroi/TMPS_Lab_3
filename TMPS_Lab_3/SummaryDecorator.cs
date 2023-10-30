using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_Lab_3
{
    // Concrete Decorator: Adding Summary to a Book
    class SummaryDecorator : AbstractBookDecorator
    {
        public string Summary { get; private set; }

        public SummaryDecorator(Book book, string summary) : base(book)
        {
            Summary = summary;
        }

        public void DisplaySummary()
        {
            Console.WriteLine($"Summary for {Title}: {Summary}");
        }
    }
}
