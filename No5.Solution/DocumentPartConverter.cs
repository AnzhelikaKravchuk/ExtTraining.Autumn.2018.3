namespace No5.Solution
{
    public abstract class DocumentPartConverter
    {
        public string DynamicVisit(DocumentPart documentPart)
            => Visit((dynamic)documentPart);
        
        protected abstract string Visit(PlainText text);

        protected abstract string Visit(HyperLink link);

        protected abstract string Visit(BoldText text);
    }
}
