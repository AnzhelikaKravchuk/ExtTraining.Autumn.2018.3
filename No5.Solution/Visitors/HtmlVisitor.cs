using No5.Solution.Part_types;

namespace No5.Solution.Visitors
{
    public class HtmlVisitor : Visitor
    {
        protected override string Visit(BoldText text) => "<b>" + text.Text + "/<b>";

        protected override string Visit(Hyperlink link) => "<a href=\"" + link.URL +"\">" + link.Text + "</a>";

        protected override string Visit(PlainText text) => text.Text;
    }
}
