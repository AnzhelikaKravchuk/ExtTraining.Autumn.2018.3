using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution.Console
{
    public class CurrentConditionsReport : IReport
    {
        public void Update(WeatherInfo info)
        {
            System.Console.WriteLine($"{nameof(CurrentConditionsReport)}");
        }
    }
}
