namespace No1.Solution.Checkers
{
    public class AdminLengthChecker : IChecker
    {
        public (bool, string) Check(string password)
        {
            if (password.Length >= 15)
                return (false, $"{password} length too long");
            else
                return (true, "");
        }
    }
}
