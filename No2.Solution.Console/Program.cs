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

            CurrentConditionsReport current = new CurrentConditionsReport();
            var currentHandler = new EventHandler<WeatherChangedEventArgs>(current.Update);
            weatherData.Register(currentHandler);

            StatisticReport statistic = new StatisticReport();
            var statisticHandler = new EventHandler<WeatherChangedEventArgs>(statistic.Update);
            weatherData.Register(statisticHandler);

            ForeCastReport forecast = new ForeCastReport();
            var forecastHandler = new EventHandler<WeatherChangedEventArgs>(forecast.Update);
            weatherData.Register(forecastHandler);

            weatherData.MeasurementsChange(12, 23, 567);
        }
    }
}
