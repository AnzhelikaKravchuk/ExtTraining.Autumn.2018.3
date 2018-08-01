using System;

namespace No5.Solution
{
    public abstract class DocumentPartVisitor
    {
        public void Visit(DocumentPart part)
        {
            if (part == null)
            {
                throw new ArgumentNullException($"{nameof(part)} is null");
            }

            Visit((dynamic)part);
        }

        protected abstract void Visit(BoldText part);

        protected abstract void Visit(Hyperlink part);

        protected abstract void Visit(PlainText part);
    }
}
