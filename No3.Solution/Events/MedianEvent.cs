using System.Linq;

namespace No3.Solution.Events
{
    public class MedianEvent
    {
        public void MedianMethod(object sender, DoubleListEventArgs args)
        {
            var sortedValues = args.Values.OrderBy(x => x).ToList();

            int n = sortedValues.Count;

            if (n % 2 == 1)
            {
                args.Result = sortedValues[(n - 1) / 2];
                return;
            }

            args.Result = (sortedValues[sortedValues.Count / 2 - 1] + sortedValues[n / 2]) / 2;
        }

        public void Subscribe(EventCalculator calcul)
        {
            calcul.AveragingMethod += this.MedianMethod;
        }

        public void Unsubscribe(EventCalculator calcul)
        {
            calcul.AveragingMethod -= this.MedianMethod;
        }
    }
}