namespace move_creation_to_factory.initial_state
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
            return StringNode.createStringNode(textBuffer, textBegin, textEnd, _parser.ShouldDecodeNodes);
        }
    }
}