using System;

namespace No2.Solution
{
    public class Bank
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
        public Bank(string name)
        {
            Name = name;
        }

        public void Update(object sender, EventArgs info)
        {
            if (info == null) throw new ArgumentNullException(nameof(info));

            var stockInfo = (StockInfo)info;

            Console.WriteLine(
                stockInfo.Euro > 40
                    ? $"Bank {this.Name} sells euros; Euro rate:{stockInfo.Euro}"
                    : $"Bank {this.Name} is buying euros; Euro rate: {stockInfo.Euro}");
        }
    }
}
