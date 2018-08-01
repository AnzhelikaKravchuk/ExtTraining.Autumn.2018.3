using System;
using No2.Solution;

namespace No2
{
    public class ForeCastReport
    {
        public void Register(IWeatherChangedPublisher publisher)
        {
            if (publisher == null)
            {
                throw new ArgumentNullException(nameof(publisher));
            }
            
            publisher.WeatherChanged += this.HandleWatherChanged;
        }

        public void Unregister(IWeatherChangedPublisher publisher)
        {
            if (publisher == null)
            {
                throw new ArgumentNullException(nameof(publisher));
            }
            
            publisher.WeatherChanged -= this.HandleWatherChanged;
        }

        private void HandleWatherChanged(object sender, WeatherChangedArgs e)
        {
            Console.WriteLine("ForeCastReport handles weather changing!");
        }
    }
}
