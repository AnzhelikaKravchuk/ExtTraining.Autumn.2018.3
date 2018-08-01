using System;

namespace No6
{
    public class FunctionData<T>
    {
        public FunctionData(T firstElement, T secondElement, Func<T, T, T> function)
        {
            if (firstElement == null)
            {
                throw new ArgumentNullException(nameof(firstElement));
            }

            if (secondElement == null)
            {
                throw new ArgumentNullException(nameof(secondElement));
            }

            if (function == null)
            {
                throw new ArgumentNullException(nameof(function));
            }

            this.FirstElement = firstElement;
            this.SecondElement = secondElement;
            this.Function = function;
        }

        public T FirstElement { get; }

        public Func<T, T, T> Function { get; }

        public T SecondElement { get; }
    }
}