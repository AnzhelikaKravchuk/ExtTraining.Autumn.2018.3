
namespace No5.Solution.DocumentParts
{
    /// <summary>
    /// Class to represent bold text.
    /// </summary>
    public class BoldText : IDocumentPart
    {
        /// <summary>
        /// Constructor of class.
        /// </summary>
        /// <param name="text">
        /// Text of class.
        /// </param>
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