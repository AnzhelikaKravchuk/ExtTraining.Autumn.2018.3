using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution.Visitors
{
    public class HtmlVisitor : Visitor
    {
        protected override string Visit(BoldText bold)
        {
            return "<b>" + bold.Text + "</b>";
        }

        protected override string Visit(Hyperlink hyperlink)
        {
            return "<a href=\"" + hyperlink.Url + "\">" + hyperlink.Text + "</a>";
        }

        protected override string Visit(PlainText plain)
        {
            return plain.Text;
        }
    }
}
