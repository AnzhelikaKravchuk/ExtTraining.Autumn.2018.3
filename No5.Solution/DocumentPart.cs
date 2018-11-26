namespace No5
{
    public abstract class DocumentPart
    {
        public string Text { get; set; }

        protected DocumentPart(string text)
        {
            Text = text;
        }

        public abstract string ToHtml();

        public abstract string ToPlainText();

        public abstract string ToLaTeX();
    }
}
