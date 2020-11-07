namespace replace_embellishment_with_decorator.refactored
{
    internal class Node : AbstractNode
    {
        public Node(int beginPosition, int endPosition) : base(beginPosition, endPosition)
        {
        }

        public override string ToPlainTextString()
        {
            return "asdf";
        }

        public override string ToHtml()
        {
            return "<h1>asdf</h1>";
        }
    }
}
