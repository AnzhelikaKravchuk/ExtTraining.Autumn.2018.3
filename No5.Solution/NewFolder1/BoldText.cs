using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public class BoldText : IDocumentPart
    {
        public string Text { get; }

        public string ConvertTo(IDocumentConverter converter)
        {
            return converter.Convert(this.Text);
        }
    }
}
