using No5.Solution.Part_types;

namespace No5.Solution.Visitors
{
    public class PlainTextVisitor : Visitor
    {
        protected override string Visit(BoldText bold) => "**" + bold.Text + "**";

        protected override string Visit(Hyperlink link) => link.Text + "[" + link.URL + "]";

        protected override string Visit(PlainText plain) => plain.Text;
    }
}
