using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public class LatexVisitor : IVisitor
    {
        public string VisitorBoldText(BoldText bold) => "\\textbf{" + bold.Text + "}";

        public string VisitorHyperlink(Hyperlink hyperlink)
            => "\\href{" + hyperlink.Url + "}{" + hyperlink.Text + "}";

        public string VisitorPlainText(PlainText plain) => plain.Text;
    }
}
