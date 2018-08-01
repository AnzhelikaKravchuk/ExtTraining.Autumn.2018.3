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
            var document = new Document();

            document.Add(new Hyperlink{Text = "NET", Url = "1234"});
            document.Add(new BoldText{Text = "NET"});
            document.Add(new PlainText{Text = "NET"});

            List<string> str = document.Accept(new HtmlVisitor());
            str.AddRange(document.Accept(new LatexVisitor()));
            str.AddRange(document.Accept(new PlainTextVisitor()));

            foreach (var item in str)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
