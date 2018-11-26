using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class StockInfoChangeEventsArgs : EventArgs
    {
        public int USD { get; set; }

        public int Euro { get; set; }

        public StockInfoChangeEventsArgs(int usd, int euro)
        {
            this.USD = usd;
            this.Euro = euro;
        }
    }
}
