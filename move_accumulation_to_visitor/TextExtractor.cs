using System;
using System.Collections.Generic;
using System.Text;

namespace move_accumulation_to_visitor
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
            _parser.flushScanners();
            _parser.registerScanners();
            foreach (var node in _parser.elements())
            {
                if (node is StringNode stringNode)
                {
                    if (!isScriptTag)
                    {
                        if (isPreTag)
                            results.Append(stringNode.getText());
                        else
                        {
                            var text = Translate.decode(stringNode.getText());
                            
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
                        Collapse(results, Translate.decode(link.GetLinkText()));
                    
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

    public class Translate
    {
        public static string decode(string text)
        {
            return text;
        }
    }

    public class Parser
    {
        public void flushScanners()
        {
            throw new NotImplementedException();
        }

        public void registerScanners()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Node> elements()
        {
            throw new NotImplementedException();
        }
    }

    public class Node
    {
    }

    public class StringNode : Node
    {
        public string getText()
        {
            return "";
        }
    }

    public class Tag : Node
    {
        public string GetTagName()
        {
            throw new NotImplementedException();
        }
    }

    public class LinkTag : Tag
    {
        public string GetLinkText()
        {
            throw new NotImplementedException();
        }

        public string GetLink()
        {
            throw new NotImplementedException();
        }
    }

    public class EndTag : Tag
    {
    }
}
