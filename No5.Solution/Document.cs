using System;
using System.Collections.Generic;

namespace No5
{
    public class Document
    {
        private readonly List<DocumentPart> _parts;

        public Document(IEnumerable<DocumentPart> parts)
        {
            if (parts == null)
            {
                throw new ArgumentNullException(nameof(parts));
            }

            this._parts = new List<DocumentPart>(parts);
        }

        public string Convert(Func<DocumentPart, string> partConverter)
        {
            var output = string.Empty;

            foreach (var part in this._parts)
            {
                output += $"{partConverter(part)}\n";
            }

            return output;
        }
    }
}
