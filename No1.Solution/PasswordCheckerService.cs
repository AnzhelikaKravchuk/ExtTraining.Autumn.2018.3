using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace No1.Solution
{
    public class PasswordCheckerService
    {
        private readonly IRepository repository = new DefaultSqlRepository();
        private string rule = @"(?=^.{8,14}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z, a-z]).*$";

        public PasswordCheckerService()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordCheckerService"/> class.
        /// </summary>
        /// <param name="repository">The custom repository.</param>
        /// <exception cref="ArgumentNullException">repository</exception>
        public PasswordCheckerService(IRepository repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public PasswordCheckerService(string regularExpression)
        {
            this.rule = regularExpression ?? throw new ArgumentNullException(nameof(regularExpression));
        }

        public PasswordCheckerService(string regularExpression, IRepository repository)
        {
            this.rule = regularExpression ?? throw new ArgumentNullException(nameof(regularExpression));
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        /// <summary>
        /// Adds the additional rule for checking password (regular expression)
        /// </summary>
        /// <param name="additionalRegularExspression">Regular exspression!</param>
        public void AddAdditionalRule(string additionalRegularExspression)
        {
            rule += additionalRegularExspression ?? throw new ArgumentNullException(nameof(additionalRegularExspression));
        }

        /// <summary>
        /// Use only default rule.
        /// </summary>
        public void ResetRuleSettings()
        {
            rule = @"(?=^.{8,14}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z, a-z]).*$";
        }

        public (bool, string) VerifyPassword(string password)
        {
            try
            {
                if (Regex.IsMatch(password, rule))
                {
                    repository.Create(password);
                    return (true, "Password is Ok. User was created");
                }
                else
                {
                    return (false, "Password is wrong");
                }
            }
            catch (ArgumentNullException)
            {
                return (false, "Null string");
            }
            catch (ArgumentException)
            {
                return (false, "Wrong regular expression");
            }           
        }
    }
}
