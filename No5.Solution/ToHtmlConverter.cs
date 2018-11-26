using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public class ToHtmlConverter : IConverter
    {
        public string Convert(List<DocumentPart> parts)
        {
            string output = string.Empty;

            foreach (DocumentPart part in parts)
            {
                switch (part.GetType().Name.ToString())
                {
                    case "Hyperlink":
                        Hyperlink hpart = (Hyperlink)part;
                        output += "<a href=\"" + hpart.Url + "\">" + hpart.Text + "</a>\n";
                        break;
                    case "PlainText":
                        output += part.Text + "\n";
                        break;
                    case "BoldText":
                        output += "<b>" + part.Text + "</b>\n";
                        break;
                    default:
                        output += "error\n";
                        break;
                }                
            }

            return output;
        }
    }
}
