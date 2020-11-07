namespace replace_embellishment_with_decorator.refactored
{
    internal class StringNode : Node
    {
        private readonly string _textBuffer;
        private int _start;
        private int _end;
        private readonly bool _shouldDecodeNodes;

        public StringNode()
        {
        }

        public StringNode(string textBuffer, int start, int end, bool shouldDecodeNodes)
        {
            _textBuffer = textBuffer;
            _start = start;
            _end = end;
            _shouldDecodeNodes = shouldDecodeNodes;
        }

        public string ToPlainTextString()
        {
            return _shouldDecodeNodes
                ? Translate.Decode(_textBuffer)
                : _textBuffer;
        }
    }
}
