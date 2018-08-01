using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using No5.Solution;

namespace No5.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document(new DocumentPart[]
            {
                new BoldText(), new Hyperlink(), new PlainText() 
            });

            System.Console.WriteLine( document.ToSelectedType(new BoldText().ToHtml));
        }
    }
}
