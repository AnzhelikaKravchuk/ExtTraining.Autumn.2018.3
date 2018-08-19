using No2.Solution;
using System;

namespace No2
{
    public class ForeCastReport : BaseWeatherListener
    {
        internal override void ExecuteChanges(object sender, WeatherArgs e)
        {
            Console.WriteLine($"ForeCastReport: {e.Pressure}");
        }
    }
}
