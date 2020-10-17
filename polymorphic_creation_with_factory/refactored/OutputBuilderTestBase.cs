namespace polymorphic_creation_with_factory.refactored
{
    public abstract class OutputBuilderTestBase : TestCase
    {
        protected OutputBuilder builder;
        protected abstract OutputBuilder CreateBuilder(string rootName);
    }
}
