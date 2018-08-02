using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public class Base64DocumentPartVisitor : DocumentPartVisitor
    {
        public string Base64Text { get; private set; }

        protected override void Visit(BoldText part)
        {
            Base64Text = Convert.ToBase64String(part.Text.Select(n => (byte) n).ToArray());
        }

        protected override void Visit(Hyperlink part)
        {
            Base64Text = Convert.ToBase64String($"{part.Url} {part.Text}".Select(n => (byte) n).ToArray());
        }

        protected override void Visit(PlainText part)
        {
            Base64Text = Convert.ToBase64String(part.Text.Select(n => (byte) n).ToArray());
        }
    }
}
