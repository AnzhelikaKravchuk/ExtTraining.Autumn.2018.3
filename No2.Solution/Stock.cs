using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class Stock:IObservable
    {
        private event EventHandler<StockInfo> MeasurementsChanged = delegate { };

        public void Market()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            var info = new StockInfo(rnd.Next(0,100)+new decimal(rnd.NextDouble()), rnd.Next(0, 100) + new decimal(rnd.NextDouble()));
            this.OnMeasurementChanged(info);
        }

        private void OnMeasurementChanged(StockInfo info)
        {
            this.MeasurementsChanged?.Invoke(this, info);
        }

        public void Register(IObserver observer)
        {
            MeasurementsChanged += observer.Update;
        }

        public void Unregister(IObserver observer)
        {
            MeasurementsChanged -= observer.Update;
        }

        void IObservable.Notify()
        {
            Market();
        }
    }
}
