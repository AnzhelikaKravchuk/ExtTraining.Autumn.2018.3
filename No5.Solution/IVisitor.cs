using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public interface IVisitor
    {
        string VisitorBoldText(BoldText bold);
        string VisitorHyperlink(Hyperlink hyperlink);
        string VisitorPlainText(PlainText plain);
    }
}
