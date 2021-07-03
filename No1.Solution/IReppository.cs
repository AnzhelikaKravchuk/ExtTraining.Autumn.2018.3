using System;
using System.Collections.Generic;

namespace No1.Solution
{
    public interface IReppository
    {
        IEnumerable<Tuple<bool, string>> Add(string password);

        IEnumerable<Tuple<bool, string>> Add(string password, IEnumerable<IPasswordCheck> chek);
    }
}
