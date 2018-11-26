using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    /*
     * Так как логик конвертации может быть бесконечно много, а методы конвертации отличаются лишь вызовом логики конвертации,
     * выделен метод Convert, принимающий стратегию конвертации.
     */
    public class Document
    {
        private readonly List<DocumentPart> parts;

        public Document(IEnumerable<DocumentPart> parts)
        {
            if (parts == null)
            {
                throw new ArgumentNullException(nameof(parts));
            }
            this.parts = new List<DocumentPart>(parts);
        }

        public string Convert(Func<DocumentPart, string> converterFunc)
        {
            string output = string.Empty;

            foreach (DocumentPart part in this.parts)
            {
                output += $"{converterFunc.Invoke(part)}\n";
            }

            return output;
        }
    }
}
