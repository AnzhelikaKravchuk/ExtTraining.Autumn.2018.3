using System;
using System.Collections.Generic;
using No1.Solution.Interfaces;

namespace No1.Solution
{
    /*
     * Воспользуемся паттерном Composite для возможности добавления различных валидаций, а также будем использовать репозиторию, не привязанную к конкретному
     * способу хранения информации.
     */
    public class PasswordCheckerService
    {
        private readonly IRepository _repository;

        private readonly IEnumerable<IPasswordValidator> _validators;

        public PasswordCheckerService(IRepository repository, IEnumerable<IPasswordValidator> validators)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository) + "must not be null.");
            _validators = validators;
        }

        public (bool, string) VerifyPassword(string password)
        {
            if (password == null)
                throw new ArgumentException($"{password} is null arg");

            if (password == string.Empty)
                return (false, $"{password} is empty ");


            foreach (var validator in _validators)
            {
                var validatorResult = validator.IsValid(password);
                if (!validatorResult.Item1)
                {
                    return validatorResult;
                }
            }

            _repository.Create(password);

            return (true, "Password is Ok. User was created");
        }
    }
}