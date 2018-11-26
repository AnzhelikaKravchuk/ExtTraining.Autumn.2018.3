using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public static class DocumentTransformer
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

        private static string Transform(this Document document, Converter<DocumentPart, string> convert)
        {
            CheckParam(document);
            CheckParam(convert);

            StringBuilder output = new StringBuilder();

            foreach (var part in document.GetParts())
            {
                output.Append($"{convert(part)}\n");
            }

            return output.ToString();
        }

        private static void CheckParam<T>(T obj) where T : class
        {
            if (obj is null)
            {
                throw new ArgumentNullException();
            }
        }
    }
}
