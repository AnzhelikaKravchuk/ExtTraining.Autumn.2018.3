
namespace No5.Solution.DocumentParts
{
    public class BoldText : IDocumentPart
    {
        public BoldText(string text)
        {
            Text = text;
        }

        public string Text { get; set; }

        public string ToHtml() => "<b>" + this.Text + "</b>";

        public string ToPlainText() => "**" + this.Text + "**";

        public string ToLaTeX() => "\\textbf{" + this.Text + "}";
    }
}