namespace No2.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();

            var currentConditionsReport = new CurrentConditionsReport();
            var statisticReport = new StatisticReport();
            var foreCastReport = new ForeCastReport();

            currentConditionsReport.Register(weatherData);
            statisticReport.Register(weatherData);
            foreCastReport.Register(weatherData);

            weatherData.MeasurementsChange(12, 23, 567);

            statisticReport.UnRegister(weatherData);

            weatherData.MeasurementsChange(1000, 2003, 9807);

            currentConditionsReport.UnRegister(weatherData);
            foreCastReport.UnRegister(weatherData);

            weatherData.MeasurementsChange(0, 0, 0);

            System.Console.ReadKey();
        }
    }
}
