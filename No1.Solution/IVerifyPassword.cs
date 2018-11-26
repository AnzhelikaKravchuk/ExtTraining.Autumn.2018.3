namespace No1.Solution
{
    public interface IVerifyPassword
    {
        (bool, string) Verify(string password);
    }
}