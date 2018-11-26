using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution
{
     public interface IAveragingMethod
     {
          double Count(List<double> values);
     }
}
