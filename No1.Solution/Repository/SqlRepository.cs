using System;
using System.IO;

namespace No1.Solution.Repository
{
    /// <summary>
    ///     Repository
    /// </summary>
    public class SqlRepository : IRepository<string>
    {
        private readonly string _fileName;

        /// <summary>
        ///     Constructor
        /// </summary>
        /// <param name="fileName">File name</param>
        /// <exception cref="ArgumentNullException">If fileName is null</exception>
        public SqlRepository(string fileName)
        {
            _fileName = fileName ?? throw new ArgumentNullException(nameof(fileName));
        }

        /// <summary>
        ///     Saves password to <see cref="IRepository{T}"/>
        /// </summary>
        /// <param name="password"><see cref="string"/> password to save</param>
        public void Create(string password)
        {
            File.AppendAllText(_fileName, password + "\n");
        }
    }
}