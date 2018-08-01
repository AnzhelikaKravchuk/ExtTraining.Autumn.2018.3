using System;
using System.Collections.Generic;

namespace No2.Solution
{
    public class WeatherInfo
    {
        int numDays;

        public WeatherInfo()
        {
            WeatherArchive = new List<string>();
        }
        public event EventHandler<MeasurementChangeEventArgs> MeasurementChange;

        private void OnMeasurementChange(object source, MeasurementChangeEventArgs e)
        {
            MeasurementChange?.Invoke(this, e);
        }

        public int Temperature { get; set; }

        public int Humidity { get; set; }

        public int Pressure { get; set; }

        public string WheatherForecast { get; private set; }

        public List<string> WeatherArchive { get; }

        public void NewDay(int temperature, int humidity, int pressure)
        {
            WheatherForecast = Forecast(temperature, humidity, pressure);
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            numDays++;
            WeatherArchive.Add($"Day#{numDays}: {Temperature}, {Humidity}, {Pressure}");
            OnMeasurementChange(this, new MeasurementChangeEventArgs(Temperature, Humidity, Pressure, WeatherArchive, WheatherForecast));
        }

        public string Forecast(int temperature, int humidity, int pressure)
        {
            if(numDays == 0)
            {
                return $"Forecast to Day#{numDays + 2}: {temperature}, {humidity}, {pressure}";
            }

            return $"Forecast to Day#{numDays + 2}: {Math.Abs(temperature - Temperature + 1) * Temperature }, {Math.Abs(humidity - Humidity + 1) * Humidity}, {Math.Abs(pressure - Pressure + 1) * Pressure}"; 
        }

    }
}
