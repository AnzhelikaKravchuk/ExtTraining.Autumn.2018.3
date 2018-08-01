using System.Collections.Generic;

namespace No5.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var parts = new List<DocumentPart>()
            {
                new BoldText() { Text = "Main title" },
                new PlainText() { Text = "Long text" },
                new Hyperlink() { Text = @"https://tut.by" },
            };

            var document = new Document(parts);
            System.Console.WriteLine(document.ToString(parts, ConversionType.LaTeX));
        }
    }
}
