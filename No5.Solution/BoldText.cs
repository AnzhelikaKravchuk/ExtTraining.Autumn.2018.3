using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public class BoldText : DocumentPart
    {
        public override string ToHtml() => "<b>" + this.Text + "</b>";

        public override string ToPlainText() => "**" + this.Text + "**";

        public override string ToLaTeX() => "\\textbf{" + this.Text + "}";
    }
}
