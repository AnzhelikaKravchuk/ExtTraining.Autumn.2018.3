using System;
using System.IO;

namespace No1.Solution
{
    public class TextFileRepository : IRepository
    {
        private readonly string _filepath;

        public TextFileRepository(string filepath)
        {
            _filepath = filepath;
        }

        public void Create(string password)
        {
            using (StreamWriter sw = new StreamWriter(_filepath, true))
            {
                sw.WriteLine(password);
            }
        }
    }
}
