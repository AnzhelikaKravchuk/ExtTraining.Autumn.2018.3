using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution.FileName
{
    public class GuidFileNameGenerator : IFileNameGenerator
    {
        public string Extension { get; set; }

        public GuidFileNameGenerator(string extension)
        {
            this.Extension = extension;
        }

        public GuidFileNameGenerator() : this(".txt") { }

        public string Generate()
        {
            return $"{Guid.NewGuid()}{Extension}";
        }
    }
}
