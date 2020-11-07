namespace replace_embellishment_with_decorator.refactored
{
    internal class Tag : AbstractNode
    {
        public Tag(int beginPosition, int endPosition) : base(beginPosition, endPosition)
        {
        }

        public override string ToPlainTextString()
        {
            throw new System.NotImplementedException();
        }

        public override string ToHtml()
        {
            throw new System.NotImplementedException();
        }
    }
}
