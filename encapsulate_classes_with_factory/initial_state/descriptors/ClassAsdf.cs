using System;

namespace encapsulate_classes_with_factory.initial_state.descriptors
{
    public abstract class AttributeDescriptor
    {
        protected AttributeDescriptor() {}
    }

    public class BooleanDescriptor : AttributeDescriptor
    {
        public BooleanDescriptor() : base()
        {
        }
    }

    public class DefaultDescriptor : AttributeDescriptor
    {
        public DefaultDescriptor(string name, Type type, Type someOtherType) : base()
        {
        }
    }

    public class ReferenceDescriptor : AttributeDescriptor
    {
        public ReferenceDescriptor(string name, Type type1, Type type2, Type type3) : base()
        {
        }
    }
}
