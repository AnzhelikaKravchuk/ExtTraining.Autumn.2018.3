using System;

namespace No2.Solution
{
    public sealed class StockInfoEventArgs : EventArgs
    {
        public int USD { get; set; }
        public int Euro { get; set; }
    }
}
