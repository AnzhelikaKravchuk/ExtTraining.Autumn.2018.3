using System;

namespace No2.Solution
{
    public class StatisticReport
    {
        public void Register(WeatherData weatherData)
        {
            weatherData.WeatherInfoEventHandler += SendStatisticReport;
        }

        public void UnRegister(WeatherData weatherData)
        {
            weatherData.WeatherInfoEventHandler -= SendStatisticReport;
        }

        private void SendStatisticReport(object sender, WeatherInfoEventArgs eventArgs) => Console.WriteLine($"Statistic report: \n {eventArgs.Humidity} \n {eventArgs.Pressure} \n {eventArgs.Temperature}");
    }
}
