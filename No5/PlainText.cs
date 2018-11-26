namespace No5
{
    public class PlainText : DocumentPart
    {
        public override string ToHtml() => this.Text;

        public override string ToPlainText() => this.Text;

        public override string ToLaTeX() => this.Text;
    }
}
