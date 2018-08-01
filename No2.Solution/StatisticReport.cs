using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2
{
    public class StatisticReport
    {
        public StatisticReport(WeatherDataManager manager)
        {
            manager.newWeatherInfo += StatisticReportMsg;
        }

        public void StatisticReportMsg(object sender, WeatherInfoEventArgs eventArgs)
        {
            Console.WriteLine("Statistic");
        }
    }
}
