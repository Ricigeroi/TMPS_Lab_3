using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_Lab_3
{
    // Proxy Pattern
    class EBookProxy : EBook
    {
        private EBook _ebook;

        public EBookProxy(EBook ebook) : base(ebook.Title, ebook.Author)
        {
            _ebook = ebook;
        }

        public override void Issue()
        {
            if (ValidLibrarian())
                _ebook.Issue();
            else
                Console.WriteLine($"Unauthorized access to e-book: {Title}");
        }

        public override void Return()
        {
            if (ValidLibrarian())
                _ebook.Return();
            else
                Console.WriteLine($"Unauthorized access to e-book: {Title}");
        }

        private bool ValidLibrarian()
        {
            // Simplified validation. In a real-world scenario, this would be more elaborate.
            return true;
        }
    }
}
