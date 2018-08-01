
namespace No5.Solution.Converter
{
    public static class DocumentConverter
    {
        public static string ToHtml(this Document document)
        {
            return Convert(document, new HtmlConverter());
        }

        public static string ToLaTex(this Document document)
        {
            return Convert(document, new LaTeXConverter());
        }

        public static string ToPlainText(this Document document)
        {
            return Convert(document, new PLainTextConverter());
        }

        private static string Convert(Document document, Converter converter)
        {
            string output = string.Empty;

            foreach (Text part in document.parts)
            {
                output += converter.Convert(part) + "\n";
            }

            return output;
        }
    }
}
