using System;
using System.Collections.Generic;
using System.Text;
using No5.Solution.DocumentParts;

namespace No5.Solution
{
    public class Document
    {
        private readonly IEnumerable<IDocumentPart> parts;

        public Document(IEnumerable<IDocumentPart> parts)
        {
            if (parts is null)
            {
                throw new ArgumentNullException(nameof(parts));
            }

            this.parts = parts;
        }

        public string ConvertTo(Func<IDocumentPart, string> converter)
        {
            var output = new StringBuilder();

            foreach (IDocumentPart part in this.parts)
            {
                output.Append($"{converter(part)}\n");
            }

            return output.ToString();
        }
    }
}
