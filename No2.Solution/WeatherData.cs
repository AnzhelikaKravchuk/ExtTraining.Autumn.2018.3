using System;

namespace No2.Solution
{
    public class WeatherData
    {
        public WeatherData()
        {
            this.WeatherInfo = new WeatherInfo();
        }

        public event EventHandler Change = delegate { };

        public WeatherInfo WeatherInfo { get; }

        public void MeasurementsChange(int temperature, int humidity, int pressure)
        {
            this.WeatherInfo.Humidity = humidity;
            this.WeatherInfo.Temperature = temperature;
            this.WeatherInfo.Pressure = pressure;
            this.OnChange(this, EventArgs.Empty);
        }

        protected virtual void OnChange(object sender, EventArgs e)
        {
            this.Change?.Invoke(this, e);
        }
    }
}