using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            var currentConditionsReport = new CurrentConditionsReport();
            currentConditionsReport.Register(weatherData);
            weatherData.MeasurementsChange(30,232,12);
            var statisticRepost = new StatisticReport();
            var foreCastReport  = new ForeCastReport();
            statisticRepost.Register(weatherData);
            foreCastReport.Register(weatherData);
            weatherData.MeasurementsChange(12, 23, 567);
        }
    }
}
