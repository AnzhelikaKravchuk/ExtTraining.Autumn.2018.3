namespace No5
{
    public class PlainText : IDocumentPart
    {
        public string Text { get; set; }

        public string Accept(IVisitor visitor)
        {
            return visitor.VisitPlain(this);
        }
    }
}
