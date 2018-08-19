using System;
namespace No2.Solution
{
    public abstract class BaseWeatherListener
    {
        public void Register(WeatherData weatherData)
        {
            if (weatherData == null)
            {
                throw new ArgumentNullException(nameof(weatherData));
            }

            weatherData.WeatherChanged += WeatherChanged;
        }

        public void UnRegister(WeatherData weatherData)
        {
            if (weatherData == null)
            {
                throw new ArgumentNullException(nameof(weatherData));
            }

            weatherData.WeatherChanged -= WeatherChanged;
        }

        public void WeatherChanged(object sender, WeatherArgs e)
        {
            if (e == null)
            {
                throw new ArgumentNullException(nameof(e));
            }

            ExecuteChanges(sender, e);
        }

        internal abstract void ExecuteChanges(object sender, WeatherArgs e);
    }
}
