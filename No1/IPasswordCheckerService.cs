using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1
{
    public interface IPasswordCheckerService<TSource>
    {
        ValueTuple<bool, TSource> VerifyPassword(TSource source);
    }
}
