using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using Visitor pattern

            BoldText bold = new BoldText() { Text = "Hello, my name is Herman"};
            Hyperlink link = new Hyperlink() { Url = "instagram.com", Text="Instagram link"};
            PlainText plain = new PlainText() { Text = "Day 20 (?) at ASP.NET Summer Express Training"};

            List<IDocumentPart> list = new List<IDocumentPart>() { bold, link, plain };

            Document document = new Document(list);

            document.Convert(new HtmlVisitor());
            document.Convert(new LaTeXVisitor());
            document.Convert(new PlainVisitor());
        }
    }
}
