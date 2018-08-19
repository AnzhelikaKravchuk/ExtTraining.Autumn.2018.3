using No2.Solution;
using System;

namespace No2
{
    public class StatisticReport : BaseWeatherListener
    {
        internal override void ExecuteChanges(object sender, WeatherArgs e)
        {
            Console.WriteLine($"StatisticReport: {e.Humidity}");
        }
    }
}
