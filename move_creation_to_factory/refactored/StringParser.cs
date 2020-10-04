namespace move_creation_to_factory.refactored
{
    internal class StringParser
    {
        private readonly Parser _parser;

        public StringParser(Parser parser)
        {
            _parser = parser;
        }

        public Node find(string textBuffer, int textBegin, int textEnd)
        {
            return new NodeFactory()
                .createStringNode(
                    textBuffer,
                    textBegin,
                    textEnd,
                    _parser.StringNodeParsingOption.ShouldDecodeNodes);
        }
    }
}