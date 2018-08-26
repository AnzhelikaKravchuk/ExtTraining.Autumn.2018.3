using System.Collections.Generic;

namespace No5.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var boldText = new BoldText
            {
                Text = "smth"
            };

            var textTypes = new List<DocumentPart>();

            textTypes.Add(boldText);

            var document = new Document(textTypes);

            System.Console.WriteLine(document.ToHtml());
            System.Console.WriteLine(document.ToLaTeX());
            System.Console.WriteLine(document.ToPlainText());

            System.Console.ReadLine();
        }
    }
}
