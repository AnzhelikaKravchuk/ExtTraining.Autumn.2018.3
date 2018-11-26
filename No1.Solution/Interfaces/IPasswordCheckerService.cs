using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution.Interfaces
{
    public interface IPasswordCheckerService<TSource,TResult>
    {
        ValueTuple<TResult, TSource> VerifyPassword(TSource source);
    }
}
