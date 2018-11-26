using System;
using System.Collections.Generic;
using System.Linq;

namespace No1.Solution.Validation
{
    /// <summary>
    ///     Composite of <see cref="IValidatable{T}"/>
    /// </summary>
    public class ValidatorComposite<T> : IValidatable<T>
    {
        private readonly ICollection<IValidatable<T>> _validators;

        /// <summary>
        ///     Constructor
        /// </summary>
        public ValidatorComposite()
        {
            _validators = new List<IValidatable<T>>();
        }

        /// <summary>
        ///     Adds <see cref="IValidatable{T}"/> to <see cref="ValidatorComposite{T}"/>
        /// </summary>
        /// <exception cref="ArgumentNullException">If validator is null</exception>
        public void AddValidator(IValidatable<T> validator)
        {
            if (validator == null) throw new ArgumentNullException(nameof(validator));

            _validators.Add(validator);
        }

        /// <summary>
        ///     Adds <see cref="Predicate{T}"/> to <see cref="ValidatorComposite{T}"/>
        /// </summary>
        /// <exception cref="ArgumentNullException">If validator is null</exception>
        public void AddValidator(Predicate<T> validator)
        {
            if (validator == null) throw new ArgumentNullException(nameof(validator));

            AddValidator(new ValidatorAdapter(validator));
        }

        /// <summary>
        ///     Removes <see cref="IValidatable{T}"/> to <see cref="ValidatorComposite{T}"/>
        /// </summary>
        /// <exception cref="ArgumentNullException">If validator is null</exception>
        public void RemoveValidator(IValidatable<T> validator)
        {
            if (validator == null) throw new ArgumentNullException(nameof(validator));

            _validators.Remove(validator);
        }

        /// <summary>
        ///     Removes <see cref="Predicate{T}"/> to <see cref="ValidatorComposite{T}"/>
        /// </summary>
        /// <exception cref="ArgumentNullException">If validator is null</exception>
        public void RemoveValidator(Predicate<T> validator)
        {
            if (validator == null) throw new ArgumentNullException(nameof(validator));

            RemoveValidator(new ValidatorAdapter(validator));
        }

        /// <summary>
        ///     Checks if input item is valid
        /// </summary>
        /// <param name="item">Source item to validation</param>
        /// <returns>True if is valid else false</returns>
        /// <exception cref="ArgumentNullException">If item is null</exception>
        public bool IsValid(T item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));

            return _validators.All(validator => validator.IsValid(item));
        }

        private class ValidatorAdapter : IValidatable<T>
        {
            private readonly Predicate<T> _predicate;

            public ValidatorAdapter(Predicate<T> predicate)
            {
                _predicate = predicate ?? throw new ArgumentNullException(nameof(predicate));
            }

            public bool IsValid(T item)
            {
                if (item == null) throw new ArgumentNullException(nameof(item));

                return _predicate(item);
            }
        }
    }
}