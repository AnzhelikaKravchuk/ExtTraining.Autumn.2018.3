using System;
using System.Collections.Generic;

namespace No5.Solution
{
    //При добавлении новой логики конвертирования приходилось в каждый класс частей документа
    //Дописывать соответствующий метод. 
    //Поэтому нужно реализовывать паттерн "Посетитель" или мультиметоды.
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

        public string ToHtml()
        {
            string output = string.Empty;

            foreach (DocumentPart part in this.parts)
            {
                output += $"{part.ToHtml()}\n";
            }

            return output;
        }

        public string ToPlainText()
        {
            string output = string.Empty;

            foreach (DocumentPart part in this.parts)
            {
                output += $"{part.ToPlainText()}\n";
            }

            return output;
        }

        public string ToLaTeX()
        {
            string output = string.Empty;

            foreach (DocumentPart part in this.parts)
            {
                output += $"{part.ToLaTeX()}\n";
            }

            return output;
        }
    }
}
