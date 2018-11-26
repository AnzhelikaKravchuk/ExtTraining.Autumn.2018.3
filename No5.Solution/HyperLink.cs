using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public class Hyperlink : DocumentPart
    {
        public string Url { get; set; }

        public override string ToHtml() => "<a href=\"" + this.Url + "\">" + this.Text + "</a>";

        public override string ToPlainText() => this.Text + " [" + this.Url + "]";

        public override string ToLaTeX() => "\\href{" + this.Url + "}{" + this.Text + "}";
    }
}
