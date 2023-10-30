using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_Lab_3
{
    // Concrete Implementations for Bridge Pattern
    class PhysicalBook : Book
    {
        public PhysicalBook(string title, string author) : base(title, author) { }

        public override void Issue()
        {
            Console.WriteLine($"Issued physical book: {Title}");
        }

        public override void Return()
        {
            Console.WriteLine($"Returned physical book: {Title}");
        }
    }
}
