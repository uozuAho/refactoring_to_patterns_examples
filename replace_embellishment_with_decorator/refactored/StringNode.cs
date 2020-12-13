namespace replace_embellishment_with_decorator.refactored
{
    internal class StringNode : AbstractNode
    {
        public override string Text { get; set; }

        public StringNode(int beginPosition, int endPosition) : base(beginPosition, endPosition)
        {
        }

        public StringNode(string textBuffer, int beginPosition, int endPosition)
            : base(beginPosition, endPosition)
        {
            TextBuffer = textBuffer;
        }

        public static INode CreateStringNode(
            string textBuffer,
            int beginPosition,
            int endPosition,
            bool shouldDecode)
        {
            if (shouldDecode)
                return new DecodingNode(textBuffer, beginPosition, endPosition);
            return new StringNode(textBuffer, beginPosition, endPosition);
        }

        public override string ToPlainTextString()
        {
            return TextBuffer;
        }

        public override string ToHtml()
        {
            throw new System.NotImplementedException();
        }
    }
}
