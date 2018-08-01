namespace No1.Solution
{
    using System;
    
    public interface IPasswordCheckerService
    {
        Tuple<bool, string> VerifyPassword(string password);
    }
}