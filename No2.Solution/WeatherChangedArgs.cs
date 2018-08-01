using System;

namespace No2.Solution
{
    public class WeatherChangedArgs : EventArgs
    {
        public WeatherChangedArgs(int temperature, int humidity, int pressure)
        {
            ThrowForInvalidParameters();
            
            this.Temperature = temperature;
            this.Humidity = humidity;
            this.Pressure = pressure;

            void ThrowForInvalidParameters()
            {
                if (temperature < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(temperature));
                }
            
                if (humidity < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(humidity));
                }
            
                if (pressure < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(pressure));
                }
            }
        }
        
        public int Temperature { get; }
        public int Humidity { get; }
        public int Pressure { get; }
    }
}