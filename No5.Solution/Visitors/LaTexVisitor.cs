using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution.Visitors
{
    public class LaTexVisitor : Visitor
    {
        protected override string Visit(BoldText bold)
        {
            return "\\textbf{" + bold.Text + "}";
        }

        protected override string Visit(Hyperlink hyperlink)
        {
            return hyperlink.Text + " [" + hyperlink.Url + "]";
        }

        protected override string Visit(PlainText plain)
        {
            return plain.Text;
        }
    }
}
