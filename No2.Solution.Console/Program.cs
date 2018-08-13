using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherInfo weatherInfo = new WeatherInfo();
            CurrentConditionsReport report1 = new CurrentConditionsReport();
            report1.Register(weatherInfo);
            StatisticReport report2 = new StatisticReport();
            report2.Register(weatherInfo);
            ForeCastReport report3 = new ForeCastReport();
            report3.Register(weatherInfo);
            weatherInfo.NewDay(12, 23, 567);
            weatherInfo.NewDay(18, 80, 357);
            weatherInfo.NewDay(18, 96, 357);

            report1.Unregister(weatherInfo);
            report2.Unregister(weatherInfo);
            report3.Unregister(weatherInfo);
        }
    }
}
