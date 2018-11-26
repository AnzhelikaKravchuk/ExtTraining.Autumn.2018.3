using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution
{
     public class Calculator
     {
          public double CalculateAverage(List<double> values, IAveragingMethod averagingMethod)
          {
               if (values == null)
               {
                    throw new ArgumentNullException(nameof(values));
               }

               if (averagingMethod == null)
               {
                    throw new ArgumentNullException();
               }

               return averagingMethod.Count(values);
          }
     }
}
