using System;
using System.Collections.Generic;
using System.Linq;

namespace No3.Solution
{
    //В данном случае реализация паттерна "Стратегия".
    //Также можно было убрать перечисление с типом вычислений и добавлять методы расширения.
    //Ну и, конечно же, можно наследоваться от данного класса и переопределять виртуальный метод с логикой вычислений.
    public class Calculator
    {
        public double CalculateAverage(List<double> values, ICalculatorMethod calculatingMethod)
        {
            if (values == null)
            {
                throw  new ArgumentNullException(nameof(values));
            }

            return calculatingMethod.Calculate(values);
        }
    }
}
