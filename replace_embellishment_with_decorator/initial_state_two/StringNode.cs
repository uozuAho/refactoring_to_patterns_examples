namespace replace_embellishment_with_decorator.initial_state_two
{
    internal class StringNode : AbstractNode
    {
        public string Text { get; set; }

        private readonly string _textBuffer;
        private readonly bool _shouldDecodeNodes;
        private readonly bool _shouldRemoveEscapeCharacters;

        public StringNode(int beginPosition, int endPosition) : base(beginPosition, endPosition)
        {
        }

        public StringNode(string textBuffer, int beginPosition, int endPosition)
            : base(beginPosition, endPosition)
        {
            _textBuffer = textBuffer;
        }

        public StringNode(
            string textBuffer,
            int beginPosition,
            int endPosition,
            bool shouldDecodeNodes,
            bool shouldRemoveEscapeCharacters) : base(beginPosition, endPosition)
        {
            _textBuffer = textBuffer;
            _shouldDecodeNodes = shouldDecodeNodes;
            _shouldRemoveEscapeCharacters = shouldRemoveEscapeCharacters;
        }

        public override string ToPlainTextString()
        {
            var result = _textBuffer;

            if (_shouldDecodeNodes)
                result = Translate.Decode(_textBuffer);
            if (_shouldRemoveEscapeCharacters)
                result = ParserUtils.RemoveEscapeCharacters(result);

            return result;
        }

        public override string ToHtml()
        {
            throw new System.NotImplementedException();
        }
    }
}
