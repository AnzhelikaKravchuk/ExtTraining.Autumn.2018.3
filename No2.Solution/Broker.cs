using System;

namespace No2.Solution
{
    public class Broker
    {
        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(value));
            }
        }

        public Broker(string name)
        {
            Name = name;
        }

        public void Update(object sender, EventArgs info)
        {
            if (info == null) throw new ArgumentNullException(nameof(info));

            var stockInfo = (StockInfo)info;

            Console.WriteLine(
                stockInfo.USD > 30
                    ? $"Broker {this.Name} sells dollars; Dollar rate: {stockInfo.USD}"
                    : $"Broker {this.Name} buys dollars; Dollar rate: {stockInfo.USD}");
        }
    }
}
