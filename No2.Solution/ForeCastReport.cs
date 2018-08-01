using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2
{
    public class ForeCastReport 
    {
        public ForeCastReport(WeatherDataManager manager)
        {
            manager.newWeatherInfo += ForeCastReportMsg;
        }

        public void ForeCastReportMsg(object sender, WeatherInfoEventArgs eventArgs)
        {
            Console.WriteLine("ForeCast");
        }
    }
}
