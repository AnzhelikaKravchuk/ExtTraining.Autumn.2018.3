using No2.Solution;
using System;

namespace No2
{
    public class StatisticReport : IObserver
    {
        public void WeatherChanged(object sender, WeatherArgs e)
        {
            Console.WriteLine($"StatisticReport: {e.Humidity}");
        }
    }
}
