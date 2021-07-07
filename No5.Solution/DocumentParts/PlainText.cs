namespace No5.Solution.DocumentParts
{
    /// <summary>
    /// Class to represent plain text format.
    /// </summary>
    public class PlainText : IDocumentPart
    {
        /// <summary>
        /// Constructor of class.
        /// </summary>
        /// <param name="valueText">
        /// Text of class.
        /// </param>
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
