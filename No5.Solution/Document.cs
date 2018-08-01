using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public class Document
    {
        private List<IText> parts = new List<IText>();

        public void Add(IText part)
        {
            parts.Add(part);
        }

        public void Remove(IText part)
        {
            parts.Remove(part);
        }

        public List<string> Accept(IVisitor visitor)
        {
            List<string> str = new List<string>();
            foreach (var part in parts)
            {
                 str.Add(part.Accept(visitor));
            }

            return str;
        }
    }
}
