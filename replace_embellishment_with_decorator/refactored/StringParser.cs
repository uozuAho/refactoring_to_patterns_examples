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
    }
}
