namespace No2.Solution.Console
{
    using Console = System.Console;

    public class Program
    {
        public static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            var curReport = new CurrentConditionsReport();
            var statReport = new StatisticReport();
            var foreCastReport = new ForeCastReport();

            curReport.Subscribe(weatherData);
            statReport.Subscribe(weatherData);
            foreCastReport.Subscribe(weatherData);

            weatherData.MeasurementsChange(12, 23, 567);

            Console.ReadKey();
        }
    }
}
