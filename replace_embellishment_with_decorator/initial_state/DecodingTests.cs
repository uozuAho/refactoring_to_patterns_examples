using System;
using System.Text;

namespace replace_embellishment_with_decorator.initial_state
{
    public class DecodingTests
    {
        public void TestDecodingAmpersand()
        {
            const string encodedWorkshopTitle = "The Testing &amp; Refactoring Workshop";
            const string decodedWorkshopTitle = "The Testing & Refactoring Workshop";

            AssertEquals("ampersand in string",
                decodedWorkshopTitle,
                ParseToObtainDecodedResult(encodedWorkshopTitle));
        }

        private string ParseToObtainDecodedResult(string stringToDecode)
        {
            var decodedContent = new StringBuilder();
            var parser = CreateParser(stringToDecode);
            var nodes = parser.Elements();
            foreach (var node in nodes)
            {
                if (node is StringNode stringNode)
                {
                    decodedContent.Append(Translate.Decode(stringNode.ToPlainTextString()));
                }
                if (node is Tag)
                    decodedContent.Append(node.toHtml());
            }
            return decodedContent.ToString();
        }

        private static Parser CreateParser(string stringToDecode)
        {
            return new Parser(stringToDecode);
        }

        private static void AssertEquals(string msg, string expected, string actual)
        {
            if (expected != actual) throw new Exception(msg);
        }
    }
}
