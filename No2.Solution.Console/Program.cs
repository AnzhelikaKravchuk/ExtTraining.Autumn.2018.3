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
            WeatherData weather = new WeatherData();
            StatisticReport report = new StatisticReport();
            CurrentConditionReport condition = new CurrentConditionReport();
            ForeCastReport foreCast = new ForeCastReport();

            weather.WeatherChanged += report.WeatherChanged;
            weather.WeatherChanged += condition.WeatherChanged;
            weather.WeatherChanged += foreCast.WeatherChanged;
            weather.CurrentWeather = new WeatherInfoArgs(11, 12, 13);
        }
    }
}
