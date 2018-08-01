using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2
{
    public class StatisticReport : IObserver
    {
        public void Update(IObservable sender, WeatherInfo info) => Console.WriteLine("Statistic");
    }
}
