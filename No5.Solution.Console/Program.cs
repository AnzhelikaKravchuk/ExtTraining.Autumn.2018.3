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
                Text = "valera chadovich"
            };

            Hyperlink link = new Hyperlink()
            {
                Text = "valera chadovich",
                Url = "https://github.com/valerycadovic"
            };

            BoldText bold = new BoldText()
            {
                Text = "bold valera chadovich"
            };
            
            Document document = new Document(new DocumentPart[] {plain, link, bold});

            System.Console.WriteLine("Base64:");
            System.Console.WriteLine(document.ToBase64());
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
