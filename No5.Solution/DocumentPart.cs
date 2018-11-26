namespace No5.Solution
{
    public abstract class DocumentPart
    {
        public DocumentPart(string text)
        {
            Text = text;
        }

        public DocumentPart() { }

        public string Text { get; set; }
    }

    public static class DocumentPartExtension
    {
        public static string ToHtml(this DocumentPart documentPart) 
            => ToHtml((dynamic)documentPart);

        private static string ToHtml(BoldText docPart)
            => "<b>" + docPart.Text + "</b>";

        private static string ToHtml(PlainText docPart) 
            => docPart.Text;

        private static string ToHtml(Hyperlink docPart)
            => "<a href=\"" + docPart.Url + "\">" + docPart.Text + "</a>";

        public static string ToPlainText(this DocumentPart documentPart) 
            => ToPlainText((dynamic)documentPart);

        private static string ToPlainText(BoldText docPart)
            => "**" + docPart.Text + "**";

        private static string ToPlainText(PlainText docPart) 
            => docPart.Text;

        private static string ToPlainText(Hyperlink docPart)
            => docPart.Text + " [" + docPart.Url + "]";

        public static string ToLaTeX(this DocumentPart documentPart) 
            => ToLaTeX((dynamic)documentPart);

        private static string ToLaTeX(BoldText docPart)
            => "\\textbf{" + docPart.Text + "}";

        private static string ToLaTeX(PlainText docPart)
            => docPart.Text;

        private static string ToLaTeX(Hyperlink docPart)
            => "\\href{" + docPart.Url + "}{" + docPart.Text + "}";
    }
}
