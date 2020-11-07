namespace replace_embellishment_with_decorator.refactored
{
    internal class StringNode : Node
    {
        private readonly string _textBuffer;
        private int _start;
        private int _end;
        private readonly bool _shouldDecodeNodes;
        private readonly bool _shouldRemoveEscapeCharacters;

        public StringNode()
        {
        }

        public StringNode(
            string textBuffer,
            int start,
            int end,
            bool shouldDecodeNodes,
            bool shouldRemoveEscapeCharacters)
        {
            _textBuffer = textBuffer;
            _start = start;
            _end = end;
            _shouldDecodeNodes = shouldDecodeNodes;
            _shouldRemoveEscapeCharacters = shouldRemoveEscapeCharacters;
        }

        public string ToPlainTextString()
        {
            var result = _textBuffer;

            if (_shouldDecodeNodes)
                result = Translate.Decode(_textBuffer);
            if (_shouldRemoveEscapeCharacters)
                result = ParserUtils.RemoveEscapeCharacters(result);

            return result;
        }
    }
}
