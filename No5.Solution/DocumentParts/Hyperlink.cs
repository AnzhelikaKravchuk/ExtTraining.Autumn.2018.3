namespace No5.Solution.DocumentParts
{
    /// <summary>
    /// Class to represent hyper link format.
    /// </summary>
    public class Hyperlink : IDocumentPart
    {

        /// <summary>
        /// Constructor of class.
        /// </summary>
        /// <param name="valueText">
        /// Text of class.
        /// </param>
        /// <param name="url">
        /// Url for hyper Link.
        /// </param>
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
