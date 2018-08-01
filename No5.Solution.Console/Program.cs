using No5.Solution.Components;
using No5.Solution.Converter;
using System.Collections.Generic;

namespace No5.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var parts = new List<Text>
            {
                new HyperLink() { Content = "to MaxArt1405", URL = "github.com/MaxArt1405" },
                new BoldTxt() { Content = "That is my repository" },
                new PlainText() { Content = "Has repository for ASP.Net Training" }
            };

            var document = new Document(parts);

            System.Console.WriteLine(document.ToHtml());
            System.Console.WriteLine(document.ToLaTex());
            System.Console.WriteLine(document.ToPlainText());

        }
    }
}
