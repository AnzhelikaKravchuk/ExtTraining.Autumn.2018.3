namespace No1.Solution.Interfaces
{
    public interface IPasswordValidator
    {
        (bool, string) IsValid(string password);
    }
}
