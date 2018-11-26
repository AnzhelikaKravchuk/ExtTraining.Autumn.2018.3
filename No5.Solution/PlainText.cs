using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public class PlainText : DocumentPart
    {
        public override string ToHtml() => this.Text;

        public override string ToPlainText() => this.Text;

        public override string ToLaTeX() => this.Text;
    }
}
