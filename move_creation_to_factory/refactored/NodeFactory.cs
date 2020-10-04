namespace move_creation_to_factory.refactored
{
    internal class NodeFactory
    {
        private readonly bool _shouldDecode;

        public NodeFactory(StringNodeParsingOption option)
        {
            _shouldDecode = option.ShouldDecodeNodes;
        }

        public Node CreateStringNode(
            string textBuffer, int textBegin, int textEnd)
        {
            if (_shouldDecode)
                return new DecodingStringNode(new StringNode(textBuffer, textBegin, textEnd));
            return new StringNode(textBuffer, textBegin, textEnd);
        }
    }
}