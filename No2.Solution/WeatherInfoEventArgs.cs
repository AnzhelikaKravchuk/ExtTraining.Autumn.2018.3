using System;

namespace No2.Solution
{
    public class WeatherInfoEventArgs : EventArgs
    {
        public int Temperature { get; set; }
        public int Humidity { get; set; }
        public int Pressure { get; set; }
    }
}
