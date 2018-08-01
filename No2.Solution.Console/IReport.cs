using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution.Console
{
    public interface IReport
    {
        void Update(WeatherInfo info);
    }
}
