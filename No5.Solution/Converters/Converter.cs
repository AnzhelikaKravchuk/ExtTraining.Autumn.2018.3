using No5.Solution.Components;

namespace No5.Solution.Converter
{
    internal abstract class Converter
    {
        public string Convert(Text part)
        {
            return this.ConvertTo((dynamic)part);
        }

        protected abstract string ConvertTo(HyperLink hyperlink);

        protected abstract string ConvertTo(PlainText plainText);

        protected abstract string ConvertTo(BoldTxt boldText);
    }
}
