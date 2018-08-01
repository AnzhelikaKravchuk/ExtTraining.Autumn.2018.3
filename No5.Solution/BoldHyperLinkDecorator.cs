namespace No5.Solution
{
    public class BoldHyperLinkDecorator : TextDecorator
    {
        public BoldHyperLinkDecorator(BoldText boldText) : base(boldText)
        {
        }

        public override string ConverTo()
        {
            return "<b>" + component.Text + "</b>"; 
        }
    }
}
