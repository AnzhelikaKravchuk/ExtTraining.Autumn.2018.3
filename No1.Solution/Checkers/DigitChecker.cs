using System.Linq;

namespace No1.Solution.Checkers
{
    public class DigitChecker: IChecker
    {
        public (bool, string) Check(string password)
        {
            if(!password.Any(char.IsNumber))
                return (false, $"{password} hasn't digits");
            else
                return (true, "");
        }
    }
}
