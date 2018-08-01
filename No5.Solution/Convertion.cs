using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public static class Convertion
    {
        public static string Convert(DocumentPart part, ConversionType type)
        {
            string result;

            if (type == ConversionType.Html)
            {
                result = part.ToHtml();

                return result;
            }

            if (type == ConversionType.LaTeX)
            {
                result = part.ToLaTeX();

                return result;
            }

            if (type == ConversionType.PlainText)
            {
                result = part.ToPlainText();

                return result;
            }

            return null;
        }
    }
}
