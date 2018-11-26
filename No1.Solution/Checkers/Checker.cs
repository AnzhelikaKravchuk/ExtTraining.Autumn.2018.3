using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution.Checkers
{
    public class Checker : IChecker
    {
        //private Func<string, bool> checkers;
        private List<Func<string, bool>> checkers;

        public Checker()
        {
            checkers = new List<Func<string, bool>>();
        }
        
        public bool Check(string password)
        {
            foreach (var checker in checkers)
            {
                if (!checker(password))
                {
                    return false;
                }
            }

            return true;
        }

        public void AppendMethod(Func<string, bool> checkMethod)
        {
            if (checkMethod is null)
            {
                throw new ArgumentNullException(nameof(checkMethod) + ", input delegate is null.");
            }

            checkers.Add(checkMethod);
        }

        public void RemoveMethod(Func<string, bool> checkMethod)
        {
            if (checkMethod is null)
            {
                throw new ArgumentNullException(nameof(checkMethod) + ", input delegate is null.");
            }

            if (checkers != null)
            {
                checkers.Remove(checkMethod);
            }
        }

        public void ClearMethods()
        {
            checkers.Clear();
        }
    }
}
