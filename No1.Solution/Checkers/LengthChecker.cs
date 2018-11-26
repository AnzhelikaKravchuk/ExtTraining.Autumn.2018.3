namespace No1.Solution.Checkers
{
    public class LengthChecker : IChecker
    {
        public (bool, string) Check(string password)
        {
            if (password.Length <= 7)
                return (false, $"{password} length too short");
            else
                return (true, "");
        }
    }
}
