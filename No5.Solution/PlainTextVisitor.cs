using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public class PlainTextVisitor : IVisitor
    {
        public string VisitorBoldText(BoldText bold) => "**" + bold.Text + "**";

        public string VisitorHyperlink(Hyperlink hyperlink) => hyperlink.Text + " [" + hyperlink.Url + "]";

        public string VisitorPlainText(PlainText plain) => plain.Text;
    }
}
