using No2.Solution;
using System;

namespace No2
{
    public class ForeCastReport : IObserver
    {
        public void WeatherChanged(object sender, WeatherArgs e)
        {
            Console.WriteLine($"ForeCastReport: {e.Pressure}");
        }
    }
}
