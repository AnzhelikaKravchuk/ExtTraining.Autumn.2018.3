using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public sealed class WeatherData
    {
        public event EventHandler<MeasurementChangedEventArgs> MeasurementsChanged;

        public void ClearData(int temperature, int humidity, int pressure)
        {
            var info = new WeatherInfo(temperature, humidity, pressure);
            this.OnMeasurementChanged(info);
        }

        private void OnMeasurementChanged(WeatherInfo info)
        {
            var args = new MeasurementChangedEventArgs(info);
            this.MeasurementsChanged?.Invoke(this, args);
        }
    }
}
