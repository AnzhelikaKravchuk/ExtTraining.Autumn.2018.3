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
            WeatherData weatherData = new WeatherData();
            StatisticReport statisticReport = new StatisticReport();
            ForeCastReport foreCastReport = new ForeCastReport();
            CurrentConditionsReport currentConditionsReport = new CurrentConditionsReport();

            statisticReport.Register(weatherData);
            foreCastReport.Register(weatherData);
            currentConditionsReport.Register(weatherData);

            weatherData.MeasurementsChange(12, 32, 44);
        }
    }
}
