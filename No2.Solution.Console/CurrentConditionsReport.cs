using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using No2.Solution;

namespace No2
{
    public class CurrentConditionsReport
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
            Console.WriteLine("CurrentConditionsReport handles weather changing!");
        }
    }
}
