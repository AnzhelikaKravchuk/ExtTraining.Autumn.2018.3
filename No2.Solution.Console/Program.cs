namespace No2.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            
            new CurrentConditionsReport().Register(weatherData);
            new StatisticReport().Register(weatherData);
            new ForeCastReport().Register(weatherData);
            
            weatherData.MeasurementsChange(12, 23, 567);
        }
    }
}
