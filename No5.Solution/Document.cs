using System;
using System.Collections.Generic;
using System.Text;
using No5.Solution.DocumentParts;

namespace No5.Solution
{
    /// <summary>
    /// Class of document.
    /// </summary>
    public class Document
    {
        private readonly IEnumerable<IDocumentPart> parts;

        /// <summary>
        /// Constructor of class.
        /// </summary>
        /// <param name="parts">
        /// <see cref="IEnumerable{T}"/> of <see cref="IDocumentPart"/>.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="parts"/> is null.
        /// </exception>
        public Document(IEnumerable<IDocumentPart> parts)
        {
            if (parts is null)
            {
                throw new ArgumentNullException(nameof(parts));
            }

            this.parts = parts;
        }

        // Универсальный метод для преобзования в нужный формат.
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
