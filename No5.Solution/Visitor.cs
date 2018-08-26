namespace No5.Solution
{
    public class Visitor : DocumentPartVisitor
    {
        #region ToHtml
        protected override string ToHtml(BoldText docPart)
        {
            if (docPart == null)
            {
                throw new System.ArgumentNullException(nameof(docPart));
            }

            return "<b>" + docPart.Text + "</b>";
        }

        protected override string ToHtml(Hyperlink docPart)
        {
            if (docPart == null)
            {
                throw new System.ArgumentNullException(nameof(docPart));
            }

            return "<a href=\"" + docPart.Url + "\">" + docPart.Text + "</a>";
        }

        protected override string ToHtml(PlainText docPart)
        {
            if (docPart == null)
            {
                throw new System.ArgumentNullException(nameof(docPart));
            }

            return docPart.Text;
        }
        #endregion

        #region ToLaTex
        protected override string ToLaTeX(BoldText docPart)
        {
            if (docPart == null)
            {
                throw new System.ArgumentNullException(nameof(docPart));
            }

            return "\\textbf{" + docPart.Text + "}";
        }

        protected override string ToLaTeX(Hyperlink docPart)
        {
            if (docPart == null)
            {
                throw new System.ArgumentNullException(nameof(docPart));
            }

            return "\\href{" + docPart.Url + "}{" + docPart.Text + "}";
        }

        protected override string ToLaTeX(PlainText docPart)
        {
            if (docPart == null)
            {
                throw new System.ArgumentNullException(nameof(docPart));
            }

            return docPart.Text;
        }
        #endregion

        #region ToPainText
        protected override string ToPlainText(BoldText docPart)
        {
            if (docPart == null)
            {
                throw new System.ArgumentNullException(nameof(docPart));
            }

            return "**" + docPart.Text + "**";
        }

        protected override string ToPlainText(Hyperlink docPart)
        {
            if (docPart == null)
            {
                throw new System.ArgumentNullException(nameof(docPart));
            }

            return docPart.Text + " [" + docPart.Url + "]";
        }

        protected override string ToPlainText(PlainText docPart)
        {
            if (docPart == null)
            {
                throw new System.ArgumentNullException(nameof(docPart));
            }

            return docPart.Text;
        }
        #endregion
    }
}
