using System;

namespace polymorphic_creation_with_factory.refactored_with_composition
{
    public class DomBuilderTest : TestCase
    {
        private OutputBuilder _builder;

        public void TestAddAboveRoot()
        {
            var invalidResult = "<orders>" +
                                "<order>" +
                                "</order>" +
                                "</orders>" +
                                "<customer>" +
                                "</customer>";
            _builder = CreateBuilder("orders");
            _builder.AddBelow("order");
            try
            {
                _builder.AddAbove("customer");
                Fail("expecting Exception");
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private static DomBuilder CreateBuilder(string rootName)
        {
            return new DomBuilder(rootName);
        }
    }
}
