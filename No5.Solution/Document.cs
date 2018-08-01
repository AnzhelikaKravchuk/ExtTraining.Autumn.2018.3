using System;
using System.Collections.Generic;

namespace No5.Solution
{
    public class Document 
    {
        private List<TextDecorator> parts;

        public Document(IEnumerable<TextDecorator> parts)
        {
            if (parts == null)
            {
                throw new ArgumentNullException(nameof(parts));
            }

            this.parts = new List<TextDecorator>(parts);
        }

        public string ConvertTo()
        {
            string output = string.Empty;

            foreach (var part in parts)
            {
                output += $"{part.ConverTo()}\n";
            }

            return output;
        }
    }
}
