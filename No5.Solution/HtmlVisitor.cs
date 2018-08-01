using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public class HtmlVisitor : IVisitor
    {
        public string VisitorBoldText(BoldText bold) => "<b>" + bold.Text + "</b>";

        public string VisitorHyperlink(Hyperlink hyperlink) =>
            "<a href=\"" + hyperlink.Url + "\">" + hyperlink.Text + "</a>";

        public string VisitorPlainText(PlainText plain) => plain.Text;
    }
}
