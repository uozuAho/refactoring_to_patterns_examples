using System.Collections.Generic;

namespace replace_embellishment_with_decorator.refactored
{
    internal class Parser
    {
        public bool ShouldDecodeNodes { get; private set; }

        private readonly string _text;

        public Parser(string text)
        {
            _text = text;
        }

        public virtual IEnumerable<Node> Elements()
        {
            yield return new Node();
            yield return new Node();
        }

        public static StringParser CreateParser(string text)
        {
            return new StringParser(text);
        }

        public void SetNodeDecoding(bool decodeStringNodes)
        {
            ShouldDecodeNodes = decodeStringNodes;
        }
    }
}
