using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class WeatherData 
    {
        public WeatherInfo WeatherInfo { get; private set; }

        public WeatherData()
        {
            WeatherInfo = new WeatherInfo();
        }

        public event EventHandler<MeasurementChangeEventArgs> MeasurementChanges = delegate { };

        public void MeasurementsChange(int temperature, int humidity, int pressure)
        {
            WeatherInfo.Humidity = humidity;
            WeatherInfo.Temperature = temperature;
            WeatherInfo.Pressure = pressure;
            OnMeasurementChanges(new MeasurementChangeEventArgs(temperature, humidity, pressure));
        }

        protected virtual void OnMeasurementChanges(MeasurementChangeEventArgs eventArgs)
        {
            EventHandler<MeasurementChangeEventArgs> tmp = MeasurementChanges;
            tmp?.Invoke(this, eventArgs);
        }
    }
}
