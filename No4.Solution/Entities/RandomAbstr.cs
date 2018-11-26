using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution.Entities
{
    /// <summary>
    /// использовал абстрактный класс для реализации схожих классов (Char, Bytes)
    /// </summary>
    public abstract class RandomAbstr
    {
        public RandomAbstr(string workDirect, string fileExt)
        {
            this.WorkingDirectory = workDirect;
            this.FileExtension = fileExt;
        }

        public string WorkingDirectory { get; set; }

        public string FileExtension { get; set; }
    }
}
