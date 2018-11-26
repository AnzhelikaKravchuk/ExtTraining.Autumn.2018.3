namespace No1.Solution
{
	public interface IPasswordValidator
	{
		(bool, string) Validate(string password);
	}
}
