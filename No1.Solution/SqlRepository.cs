using System;

namespace No1.Solution
{
    public class SqlRepository : IPasswordRepository
    {
        private static readonly Lazy<SqlRepository> LazyRepository
                    = new Lazy<SqlRepository>(() => new SqlRepository());

        public static SqlRepository Instance = LazyRepository.Value;
        
        private SqlRepository()
        {
        }    
        
        public void Create(string password) { }
    }
}