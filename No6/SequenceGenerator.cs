using System;
using System.Collections.Generic;

namespace No6
{
	public class SequenceGenerator<T>
	{
		public T FirstItem { get; }

		public T SecondItem { get; }

		public Func<T, T, T> Func { get; }

		public SequenceGenerator(T firstItem, T secondItem, Func<T, T, T> func)
		{
			FirstItem = firstItem;
			SecondItem = secondItem;
			Func = func;
		}

		public IEnumerable<T> Generate(int number)
		{
			if (number < 2)
				throw new ArgumentException("Positive integer number expected.", nameof(number));

			T a = FirstItem;
			T b = SecondItem;

			while (number-- > 0)
			{
				yield return a;

				T temp = a;
				a = b;
				b = Func(b, temp);
			}
		}
	}
}
