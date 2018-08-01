using No2.Solution;

namespace No2
{
    public interface IObserver
    {
        void WeatherChanged(object sender, WeatherArgs e);
    }
}
