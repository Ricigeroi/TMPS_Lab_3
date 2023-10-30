using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_Lab_3
{
    // Concrete Decorator: Adding Review to a Book
    class ReviewDecorator : AbstractBookDecorator
    {
        public string Review { get; private set; }

        public ReviewDecorator(Book book, string review) : base(book)
        {
            Review = review;
        }

        public void DisplayReview()
        {
            Console.WriteLine($"Review for {Title}: {Review}");
        }
    }
}
