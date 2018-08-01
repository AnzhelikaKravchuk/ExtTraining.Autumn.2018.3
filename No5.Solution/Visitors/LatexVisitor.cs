using No5.Solution.Part_types;

namespace No5.Solution.Visitors
{
    public class LatexVisitor : Visitor
    {
        protected override string Visit(BoldText bold) => "\\textbf{" + bold.Text + "}";

        protected override string Visit(Hyperlink link) => link.Text + "\\href{" + link.URL + "}{" + link.Text + "}";

        protected override string Visit(PlainText plain) => plain.Text;
    }
}
