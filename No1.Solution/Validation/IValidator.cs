using System;

namespace No1.Solution.Validation
{
    public interface IValidator
    {
        Tuple<bool, string> IsValid(string password);
    }
}
