using System;

namespace No2.Solution
{
    public class WeatherInfoArgs : EventArgs
    {
        public int Temperature { get; set; }
        public int Humidity { get; set; }
        public int Pressure { get; set; }

        public WeatherInfoArgs(int temperature, int humidity, int pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
        }
    }
}
