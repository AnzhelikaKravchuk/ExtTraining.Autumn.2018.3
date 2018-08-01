using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class StatisticReport
    {
        public void Register(WeatherInfo weather)
        {
            weather.MeasurementChange += Message;
            Console.WriteLine($"The CurrentConditionsReport registered.");
        }

        public void Unregister(WeatherInfo weather)
        {
            weather.MeasurementChange -= Message;
            Console.WriteLine($"The CurrentConditionsReport unregistered.");
        }

        private void Message(object sender, MeasurementChangeEventArgs e)
        {
            Console.WriteLine("Wheather STatistics Report: ");
            foreach (var i in e.WeatherArchive)
            {
                Console.WriteLine(i);
            }
        }
    }
}
