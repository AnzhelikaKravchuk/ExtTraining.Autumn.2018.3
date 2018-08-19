using No2.Solution;
using System;

namespace No2
{
    public class CurrentConditionsReport : BaseWeatherListener
    {
        internal override void ExecuteChanges(object sender, WeatherArgs e)
        {
            Console.WriteLine($"CurrentConditionsReport: {e.Temperature}");
        }
    }
}
