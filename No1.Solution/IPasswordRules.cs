namespace No1.Solution
{
    public interface IPasswordRules
    {
        (bool, string) VerifyPassword(string password);
    }
}