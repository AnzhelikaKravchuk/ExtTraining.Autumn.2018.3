using System;
using System.Collections.Generic;
using No5.Solution.DocumentParts;
using static System.Console;

namespace No5.Solution.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var document = new Document(new List<IDocumentPart>()
            {
                new BoldText("some"),
                new Hyperlink("1", "2"),
                new PlainText("3")
            });


            WriteLine(document.ConvertTo(s => s.ToHtml()));
            WriteLine(document.ConvertTo(s => s.ToLaTeX()));
            WriteLine(document.ConvertTo(s => s.ToPlainText()));

            ReadKey();
        }
    }
}
