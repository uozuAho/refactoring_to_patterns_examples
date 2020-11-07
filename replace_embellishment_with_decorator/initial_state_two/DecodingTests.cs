using System;
using System.Text;

namespace replace_embellishment_with_decorator.initial_state_two
{
    public class DecodingTests
    {
        public void TestDecodingAmpersand()
        {
            const string encodedWorkshopTitle = "The Testing &amp; Refactoring Workshop";
            const string decodedWorkshopTitle = "The Testing & Refactoring Workshop";

            var parser = Parser.CreateParser(encodedWorkshopTitle);
            parser.SetNodeDecoding(true);

            var decodedContent = new StringBuilder();
            foreach (var node in parser.Elements())
            {
                if (node is StringNode stringNode)
                    decodedContent.Append(stringNode.ToPlainTextString());
            }

            AssertEquals("decoded content",
                decodedWorkshopTitle,
                decodedContent.ToString());
        }

        private static void AssertEquals(string msg, string expected, string actual)
        {
            if (expected != actual) throw new Exception(msg);
        }
    }
}
