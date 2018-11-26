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
            PlainText plain = new PlainText()
            {
                Text = "Tested Text"
            };

            Hyperlink link = new Hyperlink()
            {
                Text = "Tested Text",
                Url = "https://www.google.com/"
            };

            BoldText bold = new BoldText()
            {
                Text = "Tested Text"
            };

            Document document = new Document(new DocumentPart[] { plain, link, bold });


            System.Console.WriteLine("HTML:");
            System.Console.WriteLine(document.ToHtml());
            System.Console.WriteLine("LaTeX:");
            System.Console.WriteLine(document.ToLaTeX());
            System.Console.WriteLine("Plain Text:");
            System.Console.WriteLine(document.ToPlainText());

            System.Console.ReadKey();
        }
    }
}
