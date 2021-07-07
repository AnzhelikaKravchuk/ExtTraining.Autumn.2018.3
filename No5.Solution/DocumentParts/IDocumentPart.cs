namespace No5.Solution.DocumentParts
{
    public interface IDocumentPart
    {
        string Text { get; set; }

        /// <summary>
        /// Method to convert source text to Html.
        /// </summary>
        /// <returns>
        /// Html format of text.
        /// </returns>
        string ToHtml();

        /// <summary>
        /// Method to convert source text to plainText.
        /// </summary>
        /// <returns>
        /// Plain text.
        /// </returns>
        string ToPlainText();

        /// <summary>
        /// Method to convert source text to LaTeX format.
        /// </summary>
        /// <returns>
        /// LaTeX format of text.
        /// </returns>
        string ToLaTeX();
    }
}