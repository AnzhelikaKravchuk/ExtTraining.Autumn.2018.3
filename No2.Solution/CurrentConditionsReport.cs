using No2.Solution;
using System;

namespace No2
{
    public class CurrentConditionsReport : IObserver
    {
        public void WeatherChanged(object sender, WeatherArgs e)
        {
            Console.WriteLine($"CurrentConditionsReport: {e.Temperature}");
        }
    }
}
