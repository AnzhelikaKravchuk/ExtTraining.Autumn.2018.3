using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution.Event
{
    /// <summary>
    /// хранит событие со свойствами этого же события (само сообщение, сумма купли/продажи)
    /// </summary>
    public class TradeEventArgs : EventArgs
    {
        public TradeEventArgs(string message, decimal money)
        {
            this.Message = message;
            this.Money = money;
        }

        public string Message { get; set; }

        public decimal Money { get; set; }
    }
}
