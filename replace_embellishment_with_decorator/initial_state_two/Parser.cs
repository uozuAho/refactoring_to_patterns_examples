using System.Collections.Generic;

namespace replace_embellishment_with_decorator.initial_state_two
{
    internal class Parser
    {
        public bool ShouldDecodeNodes { get; private set; }
        public bool ShouldRemoveEscapeCharacters { get; private set; }

        private readonly string _text;

        public Parser(string text)
        {
            _text = text;
        }

        public virtual IEnumerable<INode> Elements()
        {
            yield return new StringNode(0, 0);
            yield return new StringNode(0, 0);
        }

        public static StringParser CreateParser(string text)
        {
            return new StringParser(text);
        }

        public void SetNodeDecoding(bool should)
        {
            ShouldDecodeNodes = should;
        }

        public void SetRemoveEscapeCharacters(bool should)
        {
            ShouldRemoveEscapeCharacters = should;
        }
    }
}
