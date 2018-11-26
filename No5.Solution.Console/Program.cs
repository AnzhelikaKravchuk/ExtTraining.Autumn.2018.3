using System.Collections.Generic;
using static System.Console;

namespace No5.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var parts = new List<DocumentPart>
            {
                new BoldText("Denis"),
                new Hyperlink("github.com"),
                new PlainText("plain")
            };

            Document document = new Document(parts);

            WriteLine(document.Convert(part => part.ToHtml()));

            Read();
        }
    }
}
