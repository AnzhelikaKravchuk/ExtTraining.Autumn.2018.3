using System.Collections.Generic;

namespace No5.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DocumentPart> docParts = new List<DocumentPart>();

            Hyperlink link = new Hyperlink();
            link.Url = "epam.by";

            BoldText bold = new BoldText();
            bold.Text = "Bold";

            PlainText plainText = new PlainText();
            plainText.Text = "adsadas";

            docParts.Add(link);
            docParts.Add(bold);
            docParts.Add(plainText);

            Document document = new Document(docParts);

            string result = document.GetDocumentPart(p => p.ToPlainText());
        }
    }
}
