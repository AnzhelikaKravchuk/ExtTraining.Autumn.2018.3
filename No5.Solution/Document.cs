using System;
using System.Collections.Generic;

namespace No5.Solution
{
    public class Document
    {
        private List<DocumentPart> parts;

        public Document(IEnumerable<DocumentPart> parts)
        {
            if (parts == null)
            {
                throw new ArgumentNullException(nameof(parts));
            }

            this.parts = new List<DocumentPart>(parts);
        }

        public string ToSelectedType(Func<string> func)//Вот тут вот у меня супер затуп был!!!!!!!!!((((((((((((((((
        {

            string output = string.Empty;

            foreach (DocumentPart part in this.parts)
            {
                output += $"{part}\n";
            }

            return output;
        }

        //public static string ToPlainText() 
        //{
        //    string output = string.Empty;

        //    foreach (DocumentPart part in this.parts)
        //    {
        //        output += $"{part.ToPlainText()}\n";
        //    }

        //    return output;
        //}

        //    public string ToLaTeX()
        //    {
        //        string output = string.Empty;

        //        foreach (DocumentPart part in this.parts)
        //        {
        //            output += $"{part.ToLaTeX()}\n";
        //        }

        //        return output;
        //    }
        //}
    }
}
