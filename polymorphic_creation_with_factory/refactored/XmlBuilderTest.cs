namespace polymorphic_creation_with_factory.refactored
{
    public class XmlBuilderTest : OutputBuilderTestBase
    {
        protected override OutputBuilder CreateBuilder(string rootName)
        {
            return new XmlBuilder(rootName);
        }
    }
}
