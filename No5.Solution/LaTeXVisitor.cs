using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5
{
    public class LaTeXVisitor: IVisitor
    {
        public string VisitBold(BoldText txt) => "\\textbf{" + txt.Text + "}";
        public string VisitLink(Hyperlink txt) => "\\href{" + txt.Url + "}{" + txt.Text + "}";
        public string VisitPlain(PlainText txt) => txt.Text;
    }
}
