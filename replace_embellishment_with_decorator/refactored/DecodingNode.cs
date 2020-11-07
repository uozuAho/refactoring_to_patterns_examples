namespace replace_embellishment_with_decorator.refactored
{
    internal class DecodingNode : StringNode
    {
        public DecodingNode(int beginPosition, int endPosition)
            : base(beginPosition, endPosition)
        {
            ShouldDecodeNodes = true;
        }

        public DecodingNode(
            string textBuffer,
            int beginPosition,
            int endPosition)
            : base(
                textBuffer,
                beginPosition,
                endPosition)
        {
            ShouldDecodeNodes = true;
        }
    }
}
