using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Использован паттерн Visitor, ну или попытка реализации

namespace No5.Solution
{
    public abstract class Visitor
    {
        public string Visit(DocumentPart document) => Visit((dynamic)document);
        protected abstract string Visit(BoldText bold);
        protected abstract string Visit(Hyperlink hyperlink);
        protected abstract string Visit(PlainText plain);
    }
}
