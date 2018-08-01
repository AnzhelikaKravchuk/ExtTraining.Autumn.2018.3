namespace No1.Solution.Tests
{
    using System.Collections.Generic;

    public class FakeRepositoryStub : IPasswordRepository
    {
        public List<string> Passwords { get; }

        public FakeRepositoryStub()
        {
            this.Passwords = new List<string>();
        }
        
        public void Create(string password)
        {
            this.Passwords.Add(password);
        }
    }
}