using No2.Solution.Event;
using No2.Solution.Interfaces;
using No2.Solution.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution.Entities
{
    public class Trade : IObserver
    {       
        public void Update(object info)
        {
            if (info is null)
            {
                throw new ArgumentNullException(nameof(info));
            }

            var stockInfo = (StockInfo)info;

            if (stockInfo.Euro > 40)
            {
                TradeEventArgs bankEvent = new TradeEventArgs($"Bank sells euros. Euro rate: {stockInfo.Euro}", stockInfo.Euro);
                OnSell(bankEvent);
            }
            else
            {
                TradeEventArgs bankEvent = new TradeEventArgs($"Bank is buying euros. Euro rate: {stockInfo.Euro}", stockInfo.Euro);
                OnBuy(bankEvent);
            }

            if (stockInfo.USD > 30)
            {
                TradeEventArgs bankEvent = new TradeEventArgs($"Broker sells euros. USD rate: {stockInfo.USD}", stockInfo.USD);
                OnSell(bankEvent);
            }
            else
            {
                TradeEventArgs bankEvent = new TradeEventArgs($"Broker is buying euros. USD rate: {stockInfo.USD}", stockInfo.USD);
                OnBuy(bankEvent);
            }
        }

        public event EventHandler<TradeEventArgs> BuyMoney;
        public event EventHandler<TradeEventArgs> SellMoney;

        public virtual void OnBuy(TradeEventArgs e)
        {
            BuyMoney?.Invoke(this, e);
        }

        public virtual void OnSell(TradeEventArgs e)
        {
            SellMoney?.Invoke(this, e);
        }

    }
}