using System;
using System.Text;

namespace move_accumulation_to_visitor.refactored
{
    public class TextExtractor : INodeVisitor
    {
        private readonly Parser _parser = new Parser();
        private readonly bool _replaceNonBreakingSpace = false;
        private readonly bool _collapse = false;
        private readonly bool _getLinks = false;
        private bool _isPreTag;
        private bool _isScriptTag;
        private StringBuilder _results;

        public string ExtractText()
        {
            _isPreTag = false;
            _isScriptTag = false;
            _results = new StringBuilder();
            _parser.FlushScanners();
            _parser.RegisterScanners();

            foreach (var node in _parser.Elements())
            {
                node.Accept(this);
            }
            return _results.ToString();
        }

        public void VisitStringNode(StringNode stringNode)
        {
            if (!_isScriptTag)
            {
                if (_isPreTag)
                    _results.Append(stringNode.GetText());
                else
                {
                    var text = Translate.Decode(stringNode.GetText());

                    if (_replaceNonBreakingSpace)
                        text = text.Replace("\a0", " ");

                    if (_collapse)
                        Collapse(_results, text);
                    else _results.Append(text);
                }
            }
        }

        public void VisitLinkTag(LinkTag link)
        {
            if (_isPreTag)
                _results.Append(link.GetLinkText());
            else
                Collapse(_results, Translate.Decode(link.GetLinkText()));

            if (_getLinks)
            {
                _results.Append("<");
                _results.Append(link.GetLink());
                _results.Append(">");
            }
        }

        public void VisitEndTag(EndTag endTag)
        {
            var tagName = endTag.GetTagName();
            if (tagName.Equals("PRE", StringComparison.InvariantCultureIgnoreCase))
                _isPreTag = false;
            else if (tagName.Equals("SCRIPT", StringComparison.InvariantCultureIgnoreCase))
                _isScriptTag = false;
        }

        public void VisitTag(Tag tag)
        {
            var tagName = tag.GetTagName();
            if (tagName.Equals("PRE", StringComparison.InvariantCultureIgnoreCase))
                _isPreTag = true;
            else if (tagName.Equals("SCRIPT", StringComparison.InvariantCultureIgnoreCase))
                _isScriptTag = true;
        }

        private static void Collapse(StringBuilder results, string text)
        {
            throw new NotImplementedException();
        }
    }
}
