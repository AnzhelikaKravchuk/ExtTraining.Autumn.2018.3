using System;

namespace No2.Solution
{
    public class WeatherData
    {
        private WeatherInfoArgs _currentWeather;

        public event EventHandler<WeatherInfoArgs> WeatherChanged = delegate { };
        
        public WeatherInfoArgs CurrentWeather
        {
            get => _currentWeather;
            set
            {
                if (value != _currentWeather)
                {
                    _currentWeather = value;
                    OnWeatherChanged(this, value);
                }
            }
        }

        public void OnWeatherChanged(object sender, WeatherInfoArgs eventArgs)
        {
            WeatherChanged?.Invoke(this, eventArgs);
        }
    }
}
