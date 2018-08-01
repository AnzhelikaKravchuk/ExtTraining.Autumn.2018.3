using System;
using System.Collections.Generic;

namespace No2.Solution
{
    public class WeatherData
    {
        private List<IObserver> observers;

        public WeatherInfo WeatherInfo { get; private set; }

        public event EventHandler<WeatherArgs> WeatherChanged = delegate { }

        public WeatherData()
        {
            observers = new List<IObserver>();
            WeatherInfo = new WeatherInfo();
        }

        public void Notify(IObservable sender, WeatherInfo info)
        {
            foreach (var item in observers)
            {
                item.Update(this, info);
            }
        }

        public void Register(IObserver observer) => observers.Add(observer);

        public void Unregister(IObserver observer) => observers.Remove(observer);

        public void MeasurementsChange(int temperature, int humidity, int pressure)
        {
            WeatherInfo.Humidity = humidity;
            WeatherInfo.Temperature = temperature;
            WeatherInfo.Pressure = pressure;
            Notify(this, WeatherInfo);
        }
    }
}
