using System;

namespace polymorphic_creation_with_factory.refactored
{
    public class XmlBuilderTest : OutputBuilderTestBase
    {
        public void TestAddAboveRoot()
        {
            var invalidResult = "<orders>" +
                                "<order>" +
                                "</order>" +
                                "</orders>" +
                                "<customer>" +
                                "</customer>";
            Builder = CreateBuilder("orders");
            Builder.AddBelow("order");
            try
            {
                Builder.AddAbove("customer");
                Fail("expecting Exception");
            }
            catch (Exception)
            {
                // ignored
            }
        }

        protected override OutputBuilder CreateBuilder(string rootName)
        {
            return new XmlBuilder(rootName);
        }
    }
}
