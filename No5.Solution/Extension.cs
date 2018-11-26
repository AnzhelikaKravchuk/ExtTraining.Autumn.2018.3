using No5.Solution.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public static class Extension
    {
        public static string ToHtml(this DocumentPart documentPart)
        {
            HtmlVisitor visitor = new HtmlVisitor();

            return visitor.Visit(documentPart);
        }


        public static string ToLaTex(this DocumentPart documentPart)
        {
            LaTexVisitor visitor = new LaTexVisitor();

            return visitor.Visit(documentPart);
        }

        public static string ToPlainText(this DocumentPart documentPart)
        {
            PlainTextVisitor visitor = new PlainTextVisitor();

            return visitor.Visit(documentPart);
        }
    }
}
