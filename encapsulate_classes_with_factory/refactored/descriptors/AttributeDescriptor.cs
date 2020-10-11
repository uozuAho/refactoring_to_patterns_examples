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

        public static AttributeDescriptor ForSomething(string name, Type type, Type type1, Type type2)
        {
            return new ReferenceDescriptor(name, type, type1, type2);
        }
    }
}
