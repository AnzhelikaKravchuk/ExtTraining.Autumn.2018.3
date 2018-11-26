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

        public string Convert(IConverter converter)
        {
            if (converter == null)
                throw new ArgumentNullException();

            return converter.Convert(parts);
        }
    }
}
