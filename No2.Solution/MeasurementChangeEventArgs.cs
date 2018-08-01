using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public sealed class MeasurementChangeEventArgs : EventArgs
    {
        public MeasurementChangeEventArgs(int temperature, int humidity, int pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
        }

        public int Temperature { get; }
        public int Humidity { get; }
        public int Pressure { get; }
    }
}
