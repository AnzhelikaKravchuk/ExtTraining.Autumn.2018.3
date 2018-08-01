namespace No5
{
    public class Hyperlink : IDocumentPart
    {
        public string Url { get; set; }

        public string Text { get; set; }

        public string Accept(IVisitor visitor)
        {
            return visitor.VisitLink(this);
        }
    }
}
