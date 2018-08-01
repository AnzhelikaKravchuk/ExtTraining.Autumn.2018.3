using System;
using System.Collections.Generic;

namespace No5
{
    public class Document
    {
        private List<IDocumentPart> parts;

        public Document(IEnumerable<IDocumentPart> parts)
        {
            if (parts == null)
            {
                throw new ArgumentNullException(nameof(parts));
            }
            this.parts = new List<IDocumentPart>(parts);
        }

        public void Convert(IVisitor visitor)
        {
            foreach (IDocumentPart dock in parts)
                Console.WriteLine(dock.Accept(visitor));

            Console.WriteLine();
        }
    }
}
