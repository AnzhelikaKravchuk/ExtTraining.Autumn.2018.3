﻿namespace No2.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            weatherData.Register(new CurrentConditionsReport());
            weatherData.Register(new StatisticReport());
            weatherData.Register(new ForeCastReport());

            weatherData.MeasurementsChange(12, 23, 567);

            System.Console.ReadKey();
        }
    }
}
