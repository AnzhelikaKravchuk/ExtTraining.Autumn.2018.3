namespace No5.Solution
{
    public class Hyperlink : DocumentPart
    {
        public string Url { get; set; }

        public Hyperlink(string text, string url)
        {
            Text = text;
            Url = url;
        }

        public Hyperlink() { }
    }
}
