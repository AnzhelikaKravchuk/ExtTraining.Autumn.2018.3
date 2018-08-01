using System;

namespace No1.Solution
{
    public interface IVerifier
    {
        Tuple<bool, string> Verify(string password);
    }
}
