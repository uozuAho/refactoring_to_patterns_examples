namespace move_creation_to_factory.refactored
{
    internal class StringParser
    {
        private readonly Parser _parser;

        public StringParser(Parser parser)
        {
            _parser = parser;
        }

        public Node FindString(string textBuffer, int textBegin, int textEnd)
        {
            return _parser.NodeFactory
                .CreateStringNode(
                    textBuffer,
                    textBegin,
                    textEnd);
        }
    }
}