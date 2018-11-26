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
            Document document = new Document(new List<DocumentPart> { new PlainText() { Text = "efwfwefwe" },
                                             new Hyperlink() { Text = "krwjg" },
                                             new PlainText() { Text = "ewerefwe" },
                                             new BoldText() { Text = "eml;m;e" } } );

            System.Console.WriteLine(document.Convert(new ToHtmlConverter()));
            System.Console.Read();
        }
    }
}
