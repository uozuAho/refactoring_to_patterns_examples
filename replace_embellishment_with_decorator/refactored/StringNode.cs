namespace replace_embellishment_with_decorator.refactored
{
    internal class StringNode : AbstractNode
    {
        public override string Text { get; set; }

        protected bool ShouldDecodeNodes { get; set; }

        private readonly bool _shouldRemoveEscapeCharacters;

        public StringNode(int beginPosition, int endPosition) : base(beginPosition, endPosition)
        {
        }

        public StringNode(string textBuffer, int beginPosition, int endPosition)
            : base(beginPosition, endPosition)
        {
            TextBuffer = textBuffer;
        }

        public static StringNode CreateStringNode(
            string textBuffer,
            int beginPosition,
            int endPosition,
            bool shouldDecode)
        {
            return shouldDecode
                ? new DecodingNode(textBuffer, beginPosition, endPosition)
                : new StringNode(textBuffer, beginPosition, endPosition);
        }

        public override string ToPlainTextString()
        {
            var result = TextBuffer;

            if (ShouldDecodeNodes)
                result = Translate.Decode(TextBuffer);
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
