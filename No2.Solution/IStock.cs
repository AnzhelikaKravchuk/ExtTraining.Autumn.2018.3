using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public delegate void StockHandler(object sender, StockEventArgs e);

    public interface IStock
    {
        event StockHandler StockEvent;
    }
}
