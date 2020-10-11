using System;

namespace encapsulate_classes_with_factory.refactored.descriptors
{
    public abstract class AttributeDescriptor
    {
        protected AttributeDescriptor() {}

        public static AttributeDescriptor ForInteger(string name, Type type)
        {
            return new DefaultDescriptor(name, type, typeof(int));
        }

        public static DefaultDescriptor ForDate(string name, Type type)
        {
            return new DefaultDescriptor(name, type, typeof(DateTime));
        }
    }
}
