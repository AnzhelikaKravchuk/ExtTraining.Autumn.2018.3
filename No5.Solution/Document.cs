using System;
using System.Collections.Generic;

namespace No5.Solution
{
    public class Document
    {
        private List<DocumentPart> parts;

        public Document(IEnumerable<DocumentPart> parts)
        {
            if (parts == null)
            {
                throw new ArgumentNullException(nameof(parts));
            }
            this.parts = new List<DocumentPart>(parts);
        }

        public string ToString(ConversionType type)
        {
            string output = string.Empty;

            foreach (DocumentPart part in this.parts)
            {
                string temp = Convertion.Convert(part, type);

                if (temp != null)
                {
                    output += $"{temp}\n";
                }
            }

            return output;
        }
    }
}