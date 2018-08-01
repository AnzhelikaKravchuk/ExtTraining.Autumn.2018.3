using System.Linq;

namespace No3.Solution.Events
{
    public class MeanEvent
    {
        public void Subscribe(EventCalculator calcul)
        {
            calcul.AveragingMethod += this.MeanMethod;
        }

        public void Unsubscribe(EventCalculator calcul)
        {
            calcul.AveragingMethod -= this.MeanMethod;
        }

        private void MeanMethod(object sender, DoubleListEventArgs args)
        {
            args.Result = args.Values.Sum() / args.Values.Count;
        }
    }
}