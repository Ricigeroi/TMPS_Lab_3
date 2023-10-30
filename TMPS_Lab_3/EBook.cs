using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_Lab_3
{
    class EBook : Book
    {
        public EBook(string title, string author) : base(title, author) { }

        public override void Issue()
        {
            Console.WriteLine($"Issued e-book: {Title}");
        }

        public override void Return()
        {
            Console.WriteLine($"Closed e-book: {Title}");
        }
    }
}
