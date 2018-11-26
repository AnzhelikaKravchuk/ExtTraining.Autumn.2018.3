using System.Collections.Generic;
using System.Linq;

namespace No3.Solution
{
	public class MeanAverage : IAveragingMethod
	{
		public double Calculate(List<double> values)
			=> values.Sum() / values.Count;
	}
}
