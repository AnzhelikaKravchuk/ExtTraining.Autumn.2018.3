namespace No5.Solution.DocumentParts
{
    public interface IDocumentPart
    {
        string Text { get; set; }

        string ToHtml();

        string ToPlainText();

        string ToLaTeX();
    }
}