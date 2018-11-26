using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class Broker:IObserver
    {
        public string Name { get; set; }

        public Broker(string name)
        {
            this.Name = name;
        }

        public void Unregister(Stock stock)
        {
            stock.Unregister(this);
        }

        public void Update(object sender, StockInfo e)
        {
            Console.WriteLine(
                e.Euro > 40
                    ? $"Broker {this.Name} sells euros; Euro rate:{e.Euro}"
                    : $"Broker {this.Name} is buying euros; Euro rate: {e.Euro}");
        }

        public void Register(Stock stock)
        {
            stock.Register(this);
        }
    }
}
