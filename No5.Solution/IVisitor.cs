using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5
{
    public interface IVisitor
    {
        string VisitBold(BoldText txt);
        string VisitLink(Hyperlink txt);
        string VisitPlain(PlainText txt);
    }
}
