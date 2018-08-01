using System;

namespace No2.Solution
{
    public class WeatherArgs: EventArgs
    {
        public int Temperature { get; set; }
        public int Humidity { get; set; }
        public int Pressure { get; set; }
    }
}
