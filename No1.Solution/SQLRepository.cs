using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    public class SQLRepository : IRepository
    {
        private List<string> _listOfPasswords;
        private readonly IEnumerable<IPasswordChecker> _passwordCheckers;

        public SQLRepository()
        {
            _passwordCheckers = new List<IPasswordChecker>();
            _listOfPasswords = new List<string>();
        }

        public SQLRepository(IEnumerable<IPasswordChecker> passwordCheckers)
        {
            if (passwordCheckers is null)
            {
                throw new ArgumentNullException();
            }

            _listOfPasswords = new List<string>();
            _passwordCheckers = passwordCheckers;
        }

        public IEnumerable<Tuple<bool, string>> Add(string password)
        {
            List<Tuple<bool, string>> listResults = new List<Tuple<bool, string>>();
            bool isValid = true;

            foreach (var item in _passwordCheckers)
            {
                var result = item.CheckPassword(password);

                if (result.Item1 == false)
                {
                    listResults.Add(result);
                    isValid = false;
                }
            }

            if (isValid)
            {
                _listOfPasswords.Add(password);
            }

            return listResults;
        }

        public IEnumerable<Tuple<bool, string>> Add(string password, IEnumerable<IPasswordChecker> checkers)
        {
            List<Tuple<bool, string>> listResults = new List<Tuple<bool, string>>();
            bool isValid = true;

            foreach (var i in checkers)
            {
                var result = i.CheckPassword(password);

                if (result.Item1 == false)
                {
                    listResults.Add(result);
                    isValid = false;
                }
            }

            if (isValid)
            {
                _listOfPasswords.Add(password);
            }

            return listResults;
        }
    }
}
