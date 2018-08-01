using No5.Solution.DocumentPartStuff;
using No5.Solution.Part_types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution.Visitors
{
    public abstract class Visitor
    {
        public string Visit(DocumentPart part) => Visit((dynamic)part);

        protected abstract string Visit(BoldText text);
        protected abstract string Visit(Hyperlink text);
        protected abstract string Visit(PlainText text);
    }
}
