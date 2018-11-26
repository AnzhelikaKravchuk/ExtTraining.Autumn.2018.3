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
    public class Bank
    {
        private Trade trade;
        private string _name;

        public Bank(Trade trade, string name)
        {
            this.Name = name;
            this.trade = trade;
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                value = _name;
            }
        }        

        public void Result(object sender, TradeEventArgs e)
        {
            Console.WriteLine($"Bank: {this.Name}");
            Console.WriteLine(e.Message);
        }     
    }
}
