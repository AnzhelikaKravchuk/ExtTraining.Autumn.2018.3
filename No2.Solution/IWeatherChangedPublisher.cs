using System;

namespace No2.Solution
{
    public interface IWeatherChangedPublisher
    {
        event EventHandler<WeatherChangedArgs> WeatherChanged;
    }
}