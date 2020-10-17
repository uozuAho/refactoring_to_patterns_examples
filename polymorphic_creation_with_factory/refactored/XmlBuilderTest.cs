using System;

namespace polymorphic_creation_with_factory.refactored
{
    public class XmlBuilderTest : TestCase
    {
        private OutputBuilder builder;

        public void testAddAboveRoot()
        {
            var invalidResult = "<orders>" +
                                "<order>" +
                                "</order>" +
                                "</orders>" +
                                "<customer>" +
                                "</customer>";
            builder = new XmlBuilder("orders");
            builder.AddBelow("order");
            try
            {
                builder.AddAbove("customer");
                Fail("expecting Exception");
            }
            catch (Exception)
            {
                // ignored
            }
        }
    }
}
