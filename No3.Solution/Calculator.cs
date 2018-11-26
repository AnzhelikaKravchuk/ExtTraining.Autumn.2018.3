using System;
using System.Collections.Generic;

namespace No3.Solution
{
	public class Calculator
	{
		public double CalculateAverage(List<double> values, IAveragingMethod averageMethod)
		{
			if (values == null || averageMethod == null)
				throw new ArgumentNullException(values == null ? nameof(values) : nameof(averageMethod),
					"Value can not be undefined.");

			return averageMethod.Calculate(values);
		}
	}
}
