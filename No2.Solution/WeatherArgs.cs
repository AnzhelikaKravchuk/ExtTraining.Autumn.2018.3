using System;

namespace No2.Solution
{
    public class WeatherArgs : EventArgs
    {
        public WeatherArgs(int temperature, int humidity, int pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
        }

        public int Temperature { get; set; }
        public int Humidity { get; set; }
        public int Pressure { get; set; }
    }
}