using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution.CalculateMethods
{
    public class MeanCalculater : ICalculater<double>
    {
        public double Calculate(IEnumerable<double> values)
        {
            if (values is ICollection<double>)
            {
                values = values as ICollection<double>;
                double sum = values.Sum();
                int count = values.Count();

                return sum / count;
            }
            throw new ArgumentException($"{nameof(values)} bad type of collection.");
        }
    }
}
