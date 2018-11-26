namespace No1.Solution.Interfaces.IRepositoryImplementations
{
    public class SqlRepository : IRepository
    {
        private string _lastString;

        public void Create(string password)
        {
            _lastString = password;
        }

        public string GetLastAddedString(string lastString)
        {
            return _lastString;
        }
    }
}
