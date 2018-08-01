namespace No5
{
    public interface IDocumentPart
    {
        string Text { get; set; }

        string Accept(IVisitor visitor);
    }
}
