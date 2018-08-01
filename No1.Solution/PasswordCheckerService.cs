using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    public class PasswordCheckerService
    {
        private IRepository repository;
        private IEnumerable<IVerifyPassword> verifyPassword;

        public PasswordCheckerService(IRepository repository, IEnumerable<IVerifyPassword> verifyPassword)
        {
            this.repository = repository;
            this.verifyPassword = verifyPassword;
        }


        public Tuple<bool, string> VerifyPassword(string password)
        {
            Tuple<bool, string> tuple = new Tuple<bool, string>(true, "All Ok");
            foreach(var verify in verifyPassword)
            {
                tuple = verify.VerifyPassword(password);
                if(tuple.Item1 == false)
                {
                    return tuple;
                }
            }
            
            this.repository.Create(password);

            return tuple;
        }
    }
}
