using System;
using System.Text;

namespace move_accumulation_to_visitor.initial_state
{
    public class TextExtractor
    {
        private readonly Parser _parser = new Parser();
        private readonly bool _replaceNonBreakingSpace = false;
        private readonly bool _collapse = false;
        private readonly bool _getLinks = false;

        public string ExtractText()
        {
            var isPreTag = false;
            var isScriptTag = false;
            var results = new StringBuilder();
            _parser.FlushScanners();
            _parser.RegisterScanners();
            foreach (var node in _parser.Elements())
            {
                if (node is StringNode stringNode)
                {
                    if (!isScriptTag)
                    {
                        if (isPreTag)
                            results.Append(stringNode.GetText());
                        else
                        {
                            var text = Translate.Decode(stringNode.GetText());
                            
                            if (_replaceNonBreakingSpace)
                                text = text.Replace("\a0", " ");
                            
                            if (_collapse)
                                Collapse(results, text);
                            else results.Append(text);
                        }
                    }
                }
                else if (node is LinkTag link)
                {
                    if (isPreTag)
                        results.Append(link.GetLinkText());
                    else
                        Collapse(results, Translate.Decode(link.GetLinkText()));
                    
                    if (_getLinks)
                    {
                        results.Append("<");
                        results.Append(link.GetLink());
                        results.Append(">");
                    }
                }
                else if (node is EndTag endTag)
                {
                    var tagName = endTag.GetTagName();
                    if (tagName.Equals("PRE", StringComparison.InvariantCultureIgnoreCase))
                        isPreTag = false;
                    else if (tagName.Equals("SCRIPT", StringComparison.InvariantCultureIgnoreCase))
                        isScriptTag = false;
                }
                else if (node is Tag tag)
                {
                    var tagName = tag.GetTagName();
                    if (tagName.Equals("PRE", StringComparison.InvariantCultureIgnoreCase))
                        isPreTag = true;
                    else if (tagName.Equals("SCRIPT", StringComparison.InvariantCultureIgnoreCase))
                        isScriptTag = true;
                }
            }
            return results.ToString();
        }

        private static void Collapse(StringBuilder results, string text)
        {
            throw new NotImplementedException();
        }
    }
}
