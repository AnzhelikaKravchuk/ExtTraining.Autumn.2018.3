using System;

namespace No1.Solution.Services.Interfaces
{
    public interface IPasswordChekerService<in T>
    {
        Tuple<bool, string> VerifyPassword(T value);
    }
}
