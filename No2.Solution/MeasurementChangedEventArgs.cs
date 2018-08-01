using System;

namespace No2.Solution
{
    public class MeasurementChangedEventArgs : EventArgs
    {
        public MeasurementChangedEventArgs(WeatherInfo info)
        {
            this.Info = info ?? throw new ArgumentNullException();
        }

        public WeatherInfo Info { get; }
    }
}
