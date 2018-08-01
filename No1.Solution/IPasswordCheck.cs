using System;

namespace No1.Solution
{
    public interface IPasswordCheck
    {
        Tuple<bool, string> CheckPassword(string password);
    }
}
