using System;
using System.Collections.Generic;

namespace No2
{
    public class WeatherChangedEventArgs
    {
        public WeatherInfo info;
        public WeatherChangedEventArgs(WeatherInfo info)
        {
            this.info = info;
        }
    }

    public class WeatherData
    {

        public event EventHandler<WeatherChangedEventArgs> WeatherChanged;
        public virtual void OnWeatherChanged(WeatherChangedEventArgs e)
        {
            WeatherChanged?.Invoke(this, e);
        }

        public WeatherInfo WeatherInfo { get; private set; }

        public WeatherData()
        {
            WeatherInfo = new WeatherInfo();
        }

        public void Notify(WeatherInfo info)
        {
            OnWeatherChanged(new WeatherChangedEventArgs(info));
        }

        public void Register(EventHandler<WeatherChangedEventArgs> handler)
        {
            WeatherChanged += handler;
        }

        public void Unregister(EventHandler<WeatherChangedEventArgs> handler)
        {
            WeatherChanged -= handler;
        }

        public void MeasurementsChange(int temperature, int humidity, int pressure)
        {
            WeatherInfo.Humidity = humidity;
            WeatherInfo.Temperature = temperature;
            WeatherInfo.Pressure = pressure;
            Notify(WeatherInfo);
        }
    }
}
