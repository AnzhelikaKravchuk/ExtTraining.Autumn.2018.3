using System;

namespace No1.Solution
{
    public interface IPasswordValidator
    {
        Tuple<bool,string> IsRequired(string password);
    }
}