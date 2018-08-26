namespace No5.Solution
{
    public abstract class DocumentPartVisitor
    {
        #region ToHtml
        public string DynamicToHtml(DocumentPart text)
        => ToHtml((dynamic)text);
        protected abstract string ToHtml(BoldText text);
        protected abstract string ToHtml(Hyperlink text);
        protected abstract string ToHtml(PlainText text);
        #endregion

        #region ToPlainText
        public string DynamicToPlainText(DocumentPart text)
        => ToPlainText((dynamic)text);
        protected abstract string ToPlainText(BoldText text);
        protected abstract string ToPlainText(Hyperlink text);
        protected abstract string ToPlainText(PlainText text);
        #endregion

        #region ToLaTex
        public string DynamicToLaTeX(DocumentPart text)
        => ToPlainText((dynamic)text);
        protected abstract string ToLaTeX(BoldText text);
        protected abstract string ToLaTeX(Hyperlink text);
        protected abstract string ToLaTeX(PlainText text);
        #endregion
    }
}
