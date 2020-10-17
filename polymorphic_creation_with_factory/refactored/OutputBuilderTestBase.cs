using System;

namespace polymorphic_creation_with_factory.refactored
{
    public abstract class OutputBuilderTestBase : TestCase
    {
        protected OutputBuilder Builder;
        protected abstract OutputBuilder CreateBuilder(string rootName);

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
    }
}
