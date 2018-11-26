using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public class ToLaTeXConverter : IConverter
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
                        output += "\\href{" + hpart.Url + "}{" + hpart.Text + "}\n";
                        break;
                    case "PlainText":
                        output += part.Text + "\n";
                        break;
                    case "BoldText":
                        output += "\\textbf{" + part.Text + "}\n";
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
