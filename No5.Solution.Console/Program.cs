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

            List<TextDecorator> textTypes = new List<TextDecorator>();

            textTypes.Add(new BoldHyperLinkDecorator(boldText));

            var document = new Document(textTypes);

            System.Console.WriteLine(document.ConvertTo());

            System.Console.ReadLine();
        }
    }
}
