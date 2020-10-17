using System;

namespace polymorphic_creation_with_factory.refactored_with_composition
{
    public class XmlBuilderTest : TestCase
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
            _builder = new XmlBuilder("orders");
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
    }
}
