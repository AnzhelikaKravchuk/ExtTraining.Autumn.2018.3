using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace No2
{
    public class WeatherDataManager
    {
        public event EventHandler<WeatherInfoEventArgs> newWeatherInfo = delegate { };

        protected virtual void OnNewWeatherInfo(WeatherInfoEventArgs e)
        {
            EventHandler<WeatherInfoEventArgs> temp = newWeatherInfo;

            temp?.Invoke(this, e);
        }

        public void MeasurementsChange(int temperature, int humidity, int pressure)
        {
            OnNewWeatherInfo(new WeatherInfoEventArgs(temperature, humidity, pressure));
        }
    }
}
