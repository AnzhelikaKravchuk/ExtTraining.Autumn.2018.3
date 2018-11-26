using System;
using System.Linq;

namespace No1.Solution
{
	public class PasswordCheckerService
	{
		private IRepository _repository;
		private IPasswordValidator _validator;

		public PasswordCheckerService(IRepository repository, IPasswordValidator validator)
		{
			if (repository == null)
				throw new ArgumentNullException(nameof(repository), "Value can not be undefined.");

			if (validator == null)
				validator = new DefaultPasswordValidator();

			_repository = repository;
			_validator = validator;
		}

		public (bool, string) VerifyPassword(string password)
		{
			(bool isValid, string message) validationResult = _validator.Validate(password);

			if (validationResult.isValid)
				_repository.Create(password);

			return validationResult;
		}
	}
}
