namespace No1.Solution
{
    public interface IChecker
    {
        (bool, string) Check(string password);
    }
}
