namespace No5.Solution.DocumentPartConverterImplementations
{
    public class DocumentPartToPlainText : DocumentPartConverter
    {
        protected override string Visit(PlainText text) => text.Text;

        protected override string Visit(HyperLink link) => link.Text + " [" + link.Url + "]";

        protected override string Visit(BoldText text) => "**" + text.Text + "**";
    }
}