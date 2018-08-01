using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public interface IDocumentPart
    {
        string Text { get; }

        string ConvertTo(IDocumentConverter converter);
    }
}
