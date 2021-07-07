using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution.Checkers
{
    public interface IChecker
    {
        bool Check(string password);

        void AppendMethod(Func<string, bool> checkMethod);

        void RemoveMethod(Func<string, bool> checkMethod);

        void ClearMethods();
    }
}
