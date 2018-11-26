using System.Linq;

namespace No1.Solution.Checkers
{
    public class CharacterChecker : IChecker
    {
        public (bool, string) Check(string password)
        {
            if (!password.Any(char.IsLetter))
                return (false, $"{password} hasn't alphanumerical chars");
            else
                return (true, "");
        }
    }
}
