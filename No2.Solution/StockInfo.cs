using System;

namespace No2.Solution
{
    public class StockInfo : EventArgs
    {
        public decimal USD { get; set; }
        public decimal Euro { get; set; }
    }
}
