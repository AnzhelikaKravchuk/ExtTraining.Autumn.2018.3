namespace No5.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document(new DocumentPart[] {new BoldText("BoldText"), new PlainText("PlainText"), new Hyperlink("Hyperink", "Url") });
            System.Console.WriteLine(doc.ToHtml());
            System.Console.WriteLine(doc.ToLaTeX());
            System.Console.WriteLine(doc.ToPlainText());

            System.Console.ReadKey();
        }
    }
}
