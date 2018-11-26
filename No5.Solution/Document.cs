using System;
using System.Collections.Generic;

namespace No5.Solution
{
    public class Document
    {
        private readonly List<DocumentPart> parts;

        public Document(IEnumerable<DocumentPart> parts)
        {
            if (parts == null)
            {
                throw new ArgumentNullException(nameof(parts));
            }
            this.parts = new List<DocumentPart>(parts);
        }

        public string GetDocumentPart(Func<DocumentPart, string> func)
        {
            string output = string.Empty;

            foreach (DocumentPart part in parts)
            {
                output += func(part);
            }

            return output;
        }
    }
}
