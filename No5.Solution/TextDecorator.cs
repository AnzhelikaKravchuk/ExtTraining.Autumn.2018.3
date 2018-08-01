using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public abstract class TextDecorator : DocumentPart
    {
        protected DocumentPart component;

        public TextDecorator(DocumentPart component)
        {
            this.component = component;
        }

        public abstract string ConverTo();
    }
}
