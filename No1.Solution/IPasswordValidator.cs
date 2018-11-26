namespace No1.Solution
{
    /// <summary>
    /// Password validator
    /// </summary>
    public interface IPasswordValidator
    {
        (bool, string) Validate(string password);
    }
}
