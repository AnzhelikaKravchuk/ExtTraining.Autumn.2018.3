using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public static class DocumentPartExtensions
    {
        public static string ToHtml(this DocumentPart docPart)
        {
            var visitor = new Visitor();
            return visitor.DynamicToHtml(docPart);
        }

        public static string ToLaTeX(this DocumentPart docPart)
        {
            var visitor = new Visitor();
            return visitor.DynamicToLaTeX(docPart);
        }

        public static string ToPlainText(this DocumentPart docPart)
        {
            var visitor = new Visitor();
            return visitor.DynamicToPlainText(docPart);
        }
    }
}
