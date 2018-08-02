using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public static class DocumentHelper
    {
        public static string ToHtml(this Document document)
        {
            return document.Transform(p => p.ToHtml());
        }

        public static string ToPlainText(this Document document)
        {
            return document.Transform(p => p.ToPlainText());
        }

        public static string ToLaTeX(this Document document)
        {
            return document.Transform(p => p.ToLaTeX());
        }

        public static string ToBase64(this Document document)
        {
            return document.Transform(p => p.ToBase64());
        }

        private static string Transform(this Document document, Converter<DocumentPart, string> convert)
        {
            ValidateOnNull(document);
            ValidateOnNull(convert);

            StringBuilder output = new StringBuilder();

            foreach (var part in document.GetParts())
            {
                output.Append($"{convert(part)}\n");
            }

            return output.ToString();
        }

        private static void ValidateOnNull<T>(T obj) where T : class
        {
            if (obj is null)
            {
                throw new ArgumentNullException();
            }
        }
    }
}
