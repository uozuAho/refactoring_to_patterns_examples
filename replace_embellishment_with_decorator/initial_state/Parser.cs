using System.Collections.Generic;

namespace replace_embellishment_with_decorator.initial_state
{
    internal class Parser
    {
        private readonly string _text;

        public Parser(string text)
        {
            _text = text;
        }

        public IEnumerable<Node> Elements()
        {
            yield return new Node();
            yield return new Node();
        }
    }
}
