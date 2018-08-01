using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    public class PasswordCheckedEventArgs : EventArgs
    {
        private IEnumerable<string> Messages { get; }

        public PasswordCheckedEventArgs(IEnumerable<string> messages)
        {
            this.Messages = messages ?? throw new ArgumentNullException();
        }
    }
}
