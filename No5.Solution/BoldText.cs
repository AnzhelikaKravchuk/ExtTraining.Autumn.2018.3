using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public class BoldText : IText
    {
        public string Text { get; set; }

        public string Accept(IVisitor visitor)
        {
            return visitor.VisitorBoldText(this);
        }
    }
}
