namespace No5.Solution.DocumentPartConverterImplementations
{
    public class DocumentPartToHtml : DocumentPartConverter
    {
        protected override string Visit(PlainText text) => text.Text;

        protected override string Visit(HyperLink link) => "<a href=\"" + link.Url + "\">" + link.Text + "</a>";

        protected override string Visit(BoldText text) => "<b>" + text.Text + "</b>";
    }
}