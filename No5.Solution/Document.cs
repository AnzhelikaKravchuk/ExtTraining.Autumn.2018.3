using System;
using System.Collections.Generic;

namespace No5.Solution
{
    public class Document
    {
        public readonly IEnumerable<Text> parts;

        public Document(IEnumerable<Text> parts)
        {
            if (parts == null)
            {
                throw new ArgumentNullException();
            }
            this.parts = new List<Text>(parts);
        }
    }
}
