namespace No5.Solution.DocumentParts
{
    public class Hyperlink : IDocumentPart
    {
        public Hyperlink(string valueText, string url)
        {
            Text = valueText;
            Url = url;
        }

        public string Url { get; set; }

        public string Text { get; set; }

        public string ToHtml() => "<a href=\"" + this.Url + "\">" + this.Text + "</a>";

        public string ToPlainText() => this.Text + " [" + this.Url + "]";

        public string ToLaTeX() => "\\href{" + this.Url + "}{" + this.Text + "}";
    }
}
