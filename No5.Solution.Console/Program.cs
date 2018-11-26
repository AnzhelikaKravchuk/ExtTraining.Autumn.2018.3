using System;

namespace No5.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var link = new Hyperlink();
            link.Url = "git";
            link.Text = "text";
            var bold = new BoldText();
            bold.Text = "boldText";
            var plain = new PlainText();
            plain.Text = "plainText";
            DocumentPart[] parts = { link, bold, plain };
            Document document = new Document(parts);

            System.Console.WriteLine($"To Html: {document.Convert(p => p.ToHtml())}");
            System.Console.WriteLine($"To Plain text: {document.Convert(p => p.ToPlainText())}");
            System.Console.WriteLine($"To LaTeX: {document.Convert(p => p.ToLaTeX())}");

            System.Console.ReadLine();
        }
    }
}
