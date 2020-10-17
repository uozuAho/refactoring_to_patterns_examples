namespace polymorphic_creation_with_factory.refactored
{
    public class DomBuilderTest : OutputBuilderTestBase
    {
        protected override OutputBuilder CreateBuilder(string rootName)
        {
            return new DomBuilder(rootName);
        }
    }
}
