using System;

namespace No2.Solution
{
    public class CurrentConditionsReport 
    {
        public void Register(WeatherData weatherData)
        {
            weatherData.WeatherInfoEventHandler += SendCurrentConditionsReport;
        }

        public void UnRegister(WeatherData weatherData)
        {
            weatherData.WeatherInfoEventHandler -= SendCurrentConditionsReport;
        }

        private void SendCurrentConditionsReport(object sender, WeatherInfoEventArgs eventArgs) => Console.WriteLine($"CurrentConditionsReport report: \n {eventArgs.Humidity} \n {eventArgs.Pressure} \n {eventArgs.Temperature}");

    }
}
