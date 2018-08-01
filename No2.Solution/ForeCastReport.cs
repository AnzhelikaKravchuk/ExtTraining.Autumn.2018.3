using System;

namespace No2.Solution
{
    public class ForeCastReport
    {
        public void Register(WeatherData weatherData)
        {
            weatherData.WeatherInfoEventHandler += SendForeCastReport;
        }

        public void UnRegister(WeatherData weatherData)
        {
            weatherData.WeatherInfoEventHandler -= SendForeCastReport;
        }

        private void SendForeCastReport(object sender, WeatherInfoEventArgs eventArgs) => Console.WriteLine($"ForeCast report: \n {eventArgs.Humidity} \n {eventArgs.Pressure} \n {eventArgs.Temperature}");

    }
}
