using No5.Solution.DocumentPartStuff;
using No5.Solution.Part_types;
using System.Collections.Generic;
namespace No5.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DocumentPart> parts = new List<DocumentPart>
                {
                    new PlainText {Text = "Plain text"},
                    new Hyperlink {Text = "habr.ru", URL = "https://www.habr.ru/"},
                    new BoldText {Text = "Bold text"}
                };
            Document document = new Document(parts);

            System.Console.WriteLine(document.ToHTML());
            System.Console.WriteLine(document.ToPlainText());
            System.Console.WriteLine(document.ToLaTeX());
        }
    }
}
