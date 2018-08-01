using System;

namespace No2.Solution
{
    public class CurrentConditionReport
    {
        public WeatherInfoArgs Weather { get; private set; }

        public CurrentConditionReport()
        {
            Weather = new WeatherInfoArgs(0, 0, 0);
        }

        public void Register(WeatherData weatherData)
        {
            weatherData.WeatherChanged += WeatherChanged;
        }

        public void Unregister(WeatherData weatherData)
        {
            weatherData.WeatherChanged -= WeatherChanged;
        }

        public void WeatherChanged(object sender, WeatherInfoArgs args)
        {
            Console.WriteLine($"Current condition report:\n   - Temperature: {args.Temperature}\n   - Humidity: {args.Humidity}\n   - Pressure: {args.Pressure}");
        }
    }
}
