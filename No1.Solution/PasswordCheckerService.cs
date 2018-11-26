using System;
using No1.Solution.Repository;
using No1.Solution.Validation;

namespace No1.Solution
{
    /// <summary>
    ///     <see cref="PasswordCheckerService"/> class
    /// </summary>
    public static class PasswordCheckerService
    {
        /// <summary>
        ///     Checks if password is valid and save valid password to <see cref="IRepository{T}"/>
        /// </summary>
        /// <param name="password">Source password</param>
        /// <param name="validator">Source <see cref="IValidatable{T}"/></param>
        /// <param name="repository">Source <see cref="IRepository{T}"/></param>
        /// <returns>Value tuple (true, password) if is valid else (false, password)</returns>
        /// <exception cref="ArgumentNullException">If password or validator of repository is null</exception>
        public static (bool, string) VerifyPassword(string password, IValidatable<string> validator, IRepository<string> repository)
        {
            if (password == null) throw new ArgumentNullException(nameof(password));
            if (validator == null) throw new ArgumentNullException(nameof(validator));
            if (repository == null) throw new ArgumentNullException(nameof(repository));


            if (!validator.IsValid(password)) return (false, password);

            repository.Create(password);
            return (true, password);
        }
    }
}