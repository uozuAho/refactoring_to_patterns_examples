namespace replace_embellishment_with_decorator.initial_state
{
    internal class StringNode : AbstractNode
    {
        public string Text { get; set; }

        private readonly bool _shouldDecodeNodes;

        public StringNode(int beginPosition, int endPosition) : base(beginPosition, endPosition)
        {
        }

        public StringNode(string textBuffer, int beginPosition, int endPosition)
            : base(beginPosition, endPosition)
        {
            TextBuffer = textBuffer;
        }

        public StringNode(
            string textBuffer,
            int beginPosition,
            int endPosition,
            bool shouldDecodeNodes) : base(beginPosition, endPosition)
        {
            TextBuffer = textBuffer;
            _shouldDecodeNodes = shouldDecodeNodes;
        }

        public override string ToPlainTextString()
        {
            var result = TextBuffer;

            if (_shouldDecodeNodes)
                result = Translate.Decode(TextBuffer);

            return result;
        }

        public override string ToHtml()
        {
            throw new System.NotImplementedException();
        }
    }
}
