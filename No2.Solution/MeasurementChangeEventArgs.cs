using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class MeasurementChangeEventArgs : EventArgs
    {
        public MeasurementChangeEventArgs(int temperature, int humidity, int pressure, List<string> weatherArchive, string forecast)
        {
            Humidity = humidity;
            Temperature = temperature;
            Pressure = pressure;
            WeatherArchive = weatherArchive;
            Forecast = forecast;
        }

        public int Temperature { get; set; }

        public int Humidity { get; set; }

        public int Pressure { get; set; }

        public List<string> WeatherArchive { get; set; }

        public string Forecast{ get; set; }
    }
}
