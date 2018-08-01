using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            PlainText plain = new PlainText()
            {
                Text = "valera chadovich"
            };

            Hyperlink link = new Hyperlink()
            {
                Text = "valera chadovich",
                Url = "https://github.com/valerycadovic"
            };

            BoldText bold = new BoldText()
            {
                Text = "bold valera chadovich"
            };

            var a = plain.ToBase64();
            var b = link.ToBase64();
            var c = bold.ToBase64();

            System.Console.WriteLine(plain.ToBase64());
            System.Console.WriteLine(link.ToBase64());
            System.Console.WriteLine(bold.ToBase64());

            System.Console.WriteLine(Convert.FromBase64String(a).Select(n => (char)n).ToArray());
            System.Console.WriteLine(Convert.FromBase64String(b).Select(n => (char)n).ToArray());
            System.Console.WriteLine(Convert.FromBase64String(c).Select(n => (char)n).ToArray());

            System.Console.ReadKey();
        }
    }
}
