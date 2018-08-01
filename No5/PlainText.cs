namespace No5
{
    public class PlainText : DocumentPart
    {
        public override string ToHtml() => Text;

        public override string ToPlainText() => Text;

        public override string ToLaTeX() => Text;
    }
}
