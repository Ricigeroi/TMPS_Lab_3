using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_Lab_3
{
    class EBookAdapter : EBook
    {
        private ThirdPartyEBook _tpEBook;

        public EBookAdapter(ThirdPartyEBook tpEBook) : base(tpEBook.Name, tpEBook.Writer)
        {
            _tpEBook = tpEBook;
        }

        public override void Issue() { _tpEBook.Open(); }
        public override void Return() { _tpEBook.Close(); }
    }
}
