using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class StockInfo
    {
        public StockInfo(decimal USD, decimal Euro)
        {
            this.USD = USD;
            this.Euro = Euro;
        }

        public decimal USD { get; set; }
        public decimal Euro { get; set; }
    }
}
