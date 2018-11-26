using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public abstract class DocumentPartModifier
    {
        public void Modify(DocumentPart part)
        {
            if (part == null)
            {
                throw new ArgumentNullException($"{nameof(part)} is null");
            }

            Modify((dynamic)part);
        }

        protected abstract void Modify(BoldText part);

        protected abstract void Modify(Hyperlink part);

        protected abstract void Modify(PlainText part);
    }
}
