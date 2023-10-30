using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_Lab_3
{
    // Adapter Pattern: Adapting a third-party e-book format
    class ThirdPartyEBook
    {
        public string Name { get; set; }
        public string Writer { get; set; }

        public ThirdPartyEBook(string name, string writer)
        {
            Name = name;
            Writer = writer;
        }

        public void Open() { Console.WriteLine($"Opened third-party e-book: {Name}"); }
        public void Close() { Console.WriteLine($"Closed third-party e-book: {Name}"); }
    }
}
