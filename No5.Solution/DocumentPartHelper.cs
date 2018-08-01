using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public static class DocumentPartHelper
    {
        public static string ToBase64(this DocumentPart part)
        {
            if (part == null)
            {
                throw new ArgumentNullException($"{nameof(part)} is null");
            }

            Base64DocumentPartVisitor visitor = new Base64DocumentPartVisitor();
            visitor.Visit(part);
            return visitor.Base64Text;
        }
    }
}
