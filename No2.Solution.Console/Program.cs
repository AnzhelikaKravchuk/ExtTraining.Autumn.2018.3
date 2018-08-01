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

            List<IReport> reports = new List<IReport>();
            reports.Add(new ForeCastReport());
            reports.Add(new CurrentConditionsReport());

            foreach (var item in reports)
            {
                data.MeasurementsChanged += (sender, eventArgs) => item.Update(eventArgs.Info);
            }

            data.ClearData(4, 5, 7);
            System.Console.ReadKey();
        }
    }
}
