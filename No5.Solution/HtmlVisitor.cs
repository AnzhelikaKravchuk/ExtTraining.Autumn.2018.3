using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5
{
    public class HtmlVisitor: IVisitor
    {
        public string VisitBold(BoldText txt) => "<b>" + txt.Text + "</b>";
        public string VisitLink(Hyperlink txt) => "<a href=\"" + txt.Url + "\">" + txt.Text + "</a>";
        public string VisitPlain(PlainText txt) => txt.Text;
    }
}
