using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class StockInfoEventArgs : EventArgs
    {
        public int Euro { get; set; }

        public int USD { get; set; }

        public StockInfoEventArgs(int euro, int usd)
        {
            Euro = euro;
            USD = usd;
        }
    }
}
