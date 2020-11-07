using System.Collections.Generic;

namespace replace_embellishment_with_decorator.refactored
{
    internal class StringParser : Parser
    {
        public StringParser(string text) : base(text)
        {
        }

        public override IEnumerable<Node> Elements()
        {
            yield return new StringNode();
            yield return new StringNode();
        }

        public Node Find(NodeReader reader, string input, int position, bool balanceQuotes)
        {
            var textBuffer = input;
            return new StringNode(textBuffer, 0, input.Length, reader.Parser.ShouldDecodeNodes);
        }
    }
}
