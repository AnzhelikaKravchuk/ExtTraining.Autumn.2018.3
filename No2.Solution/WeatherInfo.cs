using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class WeatherInfo
    {
        public WeatherInfo(int temperature, int humidity, int pressure)
        {
            this.Temperature = temperature;
            this.Humidity = humidity;
            this.Pressure = pressure;
        }

        public int Temperature { get; }
        public int Humidity { get; }
        public int Pressure { get; }
    }
}
