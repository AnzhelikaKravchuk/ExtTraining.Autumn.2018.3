using System;

namespace No1.Solution
{
    public interface IPasswordChecker
    {
        Tuple<bool, string> CheckPassword(string password);
    }
}
