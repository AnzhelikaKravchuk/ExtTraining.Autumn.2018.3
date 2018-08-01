using No5.Solution.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution.Converter
{
    internal class PLainTextConverter : Converter
    {
        protected override string ConvertTo(HyperLink hyperlink)
        {
            return hyperlink.Content + " [" + hyperlink.URL + "]";
        }

        protected override string ConvertTo(PlainText plainText)
        {
            return plainText.Content;
        }

        protected override string ConvertTo(BoldTxt boldText)
        {
            return "**" + boldText.Content + "**";
        }
    }
}
