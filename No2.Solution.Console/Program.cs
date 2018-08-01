using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution.Console
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            WeatherDataManager manager = new WeatherDataManager();
            var forCast = new ForeCastReport(manager);
            var statistic = new StatisticReport(manager);
            var currentCondition = new CurrentConditionsReport(manager);

            manager.MeasurementsChange(21, 43, 78);
            Console.ReadKey();
        }
    }
}
