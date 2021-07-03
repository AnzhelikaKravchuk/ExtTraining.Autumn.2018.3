using System;
using System.Collections.Generic;

namespace No1.Solution
{
    public class SqlReppository : IReppository
    {
        private readonly List<string> listOfPasswords;
        private readonly IEnumerable<IPasswordCheck> passwordCheckers;

        public SqlReppository()
        {
            passwordCheckers = new List<IPasswordCheck>();
            listOfPasswords = new List<string>();
        }

        public SqlReppository(IEnumerable<IPasswordCheck> passwordCheckers)
        {
            if (passwordCheckers is null)
            {
                throw new ArgumentNullException();
            }

            listOfPasswords = new List<string>();
            this.passwordCheckers = passwordCheckers;
        }

        public IEnumerable<Tuple<bool, string>> Add(string password)
        {
            List<Tuple<bool, string>> listResults = new List<Tuple<bool, string>>();
            bool isValid = true;

            foreach (var item in passwordCheckers)
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
                listOfPasswords.Add(password);
            }

            return listResults;
        }

        public IEnumerable<Tuple<bool, string>> Add(string password, IEnumerable<IPasswordCheck> checkers)
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
                listOfPasswords.Add(password);
            }

            return listResults;
        }

    }
}
