using System.Collections.Generic;

namespace replace_embellishment_with_decorator.refactored
{
    internal class StringParser : Parser
    {
        public StringParser(string text) : base(text)
        {
        }

        public override IEnumerable<INode> Elements()
        {
            yield return new StringNode(1, 2);
            yield return new StringNode(1, 2);
        }

        public INode Find(NodeReader reader, string input, int position, bool balanceQuotes)
        {
            var textBuffer = input;
            return StringNode.CreateStringNode(
                textBuffer,
                0,
                input.Length,
                reader.Parser.ShouldDecodeNodes,
                reader.Parser.ShouldRemoveEscapeCharacters);
        }
    }
}
