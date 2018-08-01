using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class CurrentConditionsReport
    {
        public void Register(WeatherData weatherData) => 
            weatherData.MeasurementChanges += OnMeasurementChanges;

        public void UnRegister(WeatherData weatherData) => 
            weatherData.MeasurementChanges -= OnMeasurementChanges;

        public void OnMeasurementChanges(object sender, MeasurementChangeEventArgs eventArgs)
        {
            Console.WriteLine("CurrentConditions");
        }
    }
}
