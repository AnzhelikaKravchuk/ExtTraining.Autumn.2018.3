using System;
using System.Collections.Generic;

namespace No2.Solution
{
    public sealed class WeatherData 
    {
        public event EventHandler<WeatherInfoEventArgs> WeatherInfoEventHandler = delegate { };
        
        public void MeasurementsChange(int temperature, int humidity, int pressure)
        {
            var WeatherInfoEventArgs = new WeatherInfoEventArgs()
            {
                Humidity = humidity,
                Temperature = temperature,
                Pressure = pressure
            };

            OnWeatherInfoEventHandler(WeatherInfoEventArgs);    
        }

        private void OnWeatherInfoEventHandler(WeatherInfoEventArgs e)
        {
            WeatherInfoEventHandler?.Invoke(this, e);
        }
    }
}
