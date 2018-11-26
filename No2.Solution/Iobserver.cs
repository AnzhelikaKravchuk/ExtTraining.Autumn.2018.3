using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public interface IObserver
    {
        void StartTrade(Stock stock);
        void StopTrade(Stock stock);
        void Update(object sender, StockInfoEventArgs args);
    }
}
