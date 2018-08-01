using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public abstract class DocumentPartVisitor
    {
        // Нужен визитор иерархии DocumentPart, но до последнего не хотелось его делать, он некрасивый(((
        // не люблю визитор, но здесь он все-таки нужен.
    }
}
