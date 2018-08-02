using System;
using System.Collections.Generic;

namespace No3.Solution
{
    public abstract class AverageFinderDecorator : IAverageFinder
    {
        private readonly IAverageFinder parent;

        protected AverageFinderDecorator(IAverageFinder parent)
        {
            this.parent = parent ?? throw new ArgumentNullException();
        }

        public double Find(IEnumerable<double> values)
        {
            var decorated = Decorate(values);
            return parent.Find(decorated);
        }

        protected abstract IEnumerable<double> Decorate(IEnumerable<double> values);
    }
}
