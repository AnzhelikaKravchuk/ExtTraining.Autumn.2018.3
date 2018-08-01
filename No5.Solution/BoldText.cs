
namespace No5
{
    public class BoldText : IDocumentPart
    {
        public string Text { get; set; }

        public string Accept(IVisitor visitor)
        {
            return visitor.VisitBold(this);
        }
    }
}