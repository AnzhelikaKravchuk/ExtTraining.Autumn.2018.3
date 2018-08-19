using No2.Solution;
using System;

namespace No2
{
    public class WeatherData 
    {
        public event EventHandler<WeatherArgs> WeatherChanged = delegate { };

        public void MeasurementsChange(int temperature, int humidity, int pressure)
        {
            OnWeatherChange(this, new WeatherArgs(temperature, humidity, pressure));
        }

        protected virtual void OnWeatherChange(object sender, WeatherArgs eventArgs)
        {
            WeatherChanged?.Invoke(sender, eventArgs);
        }
    }
}
