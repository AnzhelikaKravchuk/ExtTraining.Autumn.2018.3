using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5
{
    public class PlainVisitor: IVisitor
    {
        public string VisitBold(BoldText txt) => "**" + txt.Text + "**";
        public string VisitLink(Hyperlink txt) => txt.Text + " [" + txt.Url + "]";
        public string VisitPlain(PlainText txt) => txt.Text;
    }
}
