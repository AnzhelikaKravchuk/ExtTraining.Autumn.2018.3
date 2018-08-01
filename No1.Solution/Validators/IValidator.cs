using System;

namespace No1.Solution.Validators
{
    public interface IValidator<in T>
    {
        Tuple<bool, string> IsValid(T value);
    }
}
