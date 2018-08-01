using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public interface IText
    {
        string Text { get; set; }
        string Accept(IVisitor visitor);
    }
}
