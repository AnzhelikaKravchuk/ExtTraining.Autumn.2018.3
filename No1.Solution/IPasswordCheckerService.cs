using System;

namespace No1
{
    public interface IPasswordCheckerService<T>
    {
        Tuple<bool, T> VerifyPassword(T password);
    }
}