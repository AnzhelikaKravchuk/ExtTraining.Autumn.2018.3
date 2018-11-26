namespace No1.Solution.Checkers
{
    public class EmptyChecker : IChecker
    {
        public (bool, string) Check(string password)
        {
            if (password == string.Empty)
                return (false, $"{password} is empty ");
            else
                return (true, "");
        }
    }
}
