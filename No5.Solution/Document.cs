using System;
using System.Collections.Generic;
using No5.Solution.DocumentPartStuff;

namespace No5.Solution
{
    public class Document
    {
        private List<DocumentPart> _parts;

        public Document(IEnumerable<DocumentPart> parts)
        {
            _parts = new List<DocumentPart>(parts) ?? throw new ArgumentNullException($"{nameof(parts)} can't be equal to null!");
        }

        public string ToHTML()
        {
            string output = string.Empty;
            foreach (DocumentPart part in _parts)
            {
                output += $"{part.ToHTML()}\n";
            }

            return output;
        }

        public string ToPlainText()
        {
            string output = string.Empty;
            foreach (DocumentPart part in _parts)
            {
                output += $"{part.ToPlainText()}\n";
            }

            return output;
        }

        public string ToLaTeX()
        {
            string output = string.Empty;
            foreach (DocumentPart part in _parts)
            {
                output += $"{part.ToLaTeX()}\n";
            }

            return output;
        }

        public string ToBoldText()
        {
            string output = string.Empty;
            foreach (DocumentPart part in _parts)
            {
                output += $"{part.ToBoldText()}\n";
            }

            return output;
        }
    }
}
