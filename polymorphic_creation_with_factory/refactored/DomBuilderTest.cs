using System;

namespace polymorphic_creation_with_factory.refactored
{
    public class DomBuilderTest : OutputBuilderTestBase
    {
        public void TestAddAboveRoot()
        {
            var invalidResult = "<orders>" +
                                "<order>" +
                                "</order>" +
                                "</orders>" +
                                "<customer>" +
                                "</customer>";
            builder = CreateBuilder("orders");
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

        protected override OutputBuilder CreateBuilder(string rootName)
        {
            return new DomBuilder(rootName);
        }
    }
}
