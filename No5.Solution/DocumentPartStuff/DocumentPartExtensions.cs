using No5.Solution.Visitors;

namespace No5.Solution.DocumentPartStuff
{
    public static class DocumentPartExtensions
    {
        public static string ToHTML(this DocumentPart part)
        {
            Visitor visitor = new HtmlVisitor();

            return visitor.Visit(part);
        }

        public static string ToPlainText(this DocumentPart part)
        {
            Visitor visitor = new PlainTextVisitor();

            return visitor.Visit(part);
        }

        public static string ToLaTeX(this DocumentPart part)
        {
            Visitor visitor = new LatexVisitor();

            return visitor.Visit(part);
        }

        public static string ToBoldText(this DocumentPart part)
        {
            Visitor visitor = new BoldTextVisitor();

            return visitor.Visit(part);
        }
    }
}
