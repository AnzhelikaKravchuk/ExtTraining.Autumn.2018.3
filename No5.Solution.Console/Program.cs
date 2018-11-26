using System.Collections.Generic;
using No5.Solution.DocumentPartConverterImplementations;

namespace No5.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var doc1 = new BoldText() {Text = "plain text"};
            var doc2 = new HyperLink(){Text = "hyper link"};
            var docs = new List<DocumentPart>() {doc1, doc2};

            var document = new Document(docs);
            var converted = document.ConvertTo(new DocumentPartToHtml());
            System.Console.WriteLine(converted);
        }
    }
}
