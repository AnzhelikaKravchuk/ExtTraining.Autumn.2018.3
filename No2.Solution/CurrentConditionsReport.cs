using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2
{
    public class CurrentConditionsReport
    {
        public CurrentConditionsReport(WeatherDataManager manager)
        {
            manager.newWeatherInfo += CurrentConditionsReportMsg;
        }

        public void CurrentConditionsReportMsg(object sender, WeatherInfoEventArgs eventArgs)
        {
            Console.WriteLine("CurrentConditions");
        }
    }
}
