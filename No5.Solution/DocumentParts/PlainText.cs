namespace No5.Solution.DocumentParts
{
    public class PlainText : IDocumentPart
    {
        public PlainText(string valueText)
        {
            Text = valueText;
        }

        public string Text { get; set; }

        public string ToHtml() => this.Text;

        public string ToPlainText() => this.Text;

        public string ToLaTeX() => this.Text;
    }
}
