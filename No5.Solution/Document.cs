using System;
using System.Collections.Generic;

namespace No5.Solution
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

            _parts = new List<DocumentPart>(parts);
        }

        /**
         * Различные методы конвертации были заменены одним методом,
         * принимающим логику трансформации объекта класса DocumentPart
         * в его строковое представление.
         */

        public string Convert(Func<DocumentPart, string> partConverter)
        {
            var output = string.Empty;

            foreach (var part in _parts)
            {
                output += $"{partConverter(part)}\n";
            }

            return output;
        }
    }
}
