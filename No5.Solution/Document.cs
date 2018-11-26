using System;
using System.Collections.Generic;

namespace No5.Solution
{
    /*
     * Так как количество частей документа не изменяется, а формат, в который они могут переводится - да, то мы реализуем динамический паттерн визитора.
     * Сами классы в дальнейшем изменяться не будут, а вот добавить новый формат мы сможем легко, унаследовавшись от DocumentPartConverter.
     */
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

        public string ConvertTo(DocumentPartConverter converter)
        {
            string output = string.Empty;

            foreach (DocumentPart part in this.parts)
            {
                output += $"{converter.DynamicVisit(part)}\n";
            }

            return output;
        }
    }
}