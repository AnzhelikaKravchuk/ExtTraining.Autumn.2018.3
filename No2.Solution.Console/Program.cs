using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherData = No2.Solution.WeatherData;

namespace No2.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData data = new WeatherData();

            var a = new ForeCastReport();
            var b = new CurrentConditionsReport();

            data.MeasurementsChanged += (sender, eventArgs) => a.Update(eventArgs.Info);
            data.MeasurementsChanged += (sender, eventArgs) => b.Update(eventArgs.Info);

            data.ClearData(4, 5, 7);
            System.Console.ReadKey();
        }
    }
}
