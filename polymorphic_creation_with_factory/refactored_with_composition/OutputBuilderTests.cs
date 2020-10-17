using System;
using NUnit.Framework;

namespace polymorphic_creation_with_factory.refactored_with_composition
{
    [TestFixture(typeof(DomBuilder))]
    [TestFixture(typeof(XmlBuilder))]
    public class OutputBuilderTests
    {
        private OutputBuilder _builder;
        private readonly Type _builderType;

        public OutputBuilderTests(Type builderType)
        {
            _builderType = builderType;
        }

        [SetUp]
        public void Setup()
        {
            _builder = (OutputBuilder) Activator.CreateInstance(_builderType, "orders");
        }

        [Test]
        public void TestAddAboveRoot()
        {
            var invalidResult = "<orders>" +
                                "<order>" +
                                "</order>" +
                                "</orders>" +
                                "<customer>" +
                                "</customer>";
            _builder.AddBelow("order");
            try
            {
                _builder.AddAbove("customer");
                Assert.Fail("expecting Exception");
            }
            catch (Exception)
            {
                // ignored
            }
        }
    }
}
