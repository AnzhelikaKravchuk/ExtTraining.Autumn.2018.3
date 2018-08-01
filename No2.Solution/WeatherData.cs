using System;

namespace No2.Solution
{
    public class WeatherData : IWeatherChangedPublisher
    {
        public event EventHandler<WeatherChangedArgs> WeatherChanged;
        
        public void MeasurementsChange(int temperature, int humidity, int pressure)
        {
            var args = new WeatherChangedArgs(temperature, humidity, pressure);

            this.OnWeatherChanger(args);
        }
        
        protected virtual void OnWeatherChanger(WeatherChangedArgs args)
        {
            if (args == null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            
            this.WeatherChanged?.Invoke(this, args);
        }
    }
}