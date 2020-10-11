using System.Collections.Generic;
using encapsulate_classes_with_factory.refactored.descriptors;

namespace encapsulate_classes_with_factory.refactored
{
    public class Client
    {
        public static List<AttributeDescriptor> CreateAttributeDescriptors()
        {
            var result = new List<AttributeDescriptor>
            {
                AttributeDescriptor.ForInteger("remoteId", typeof(Client)),
                AttributeDescriptor.ForDate("createdDate", typeof(Client)),
                AttributeDescriptor.ForDate("lastChangedDate", typeof(Client)),
                AttributeDescriptor.ForSomething("createdBy", typeof(Client), typeof(User), typeof(RemoteUser)),
                AttributeDescriptor.ForSomething("lastChangedBy", typeof(Client), typeof(User), typeof(RemoteUser)),
                AttributeDescriptor.ForInteger("optimisticLockVersion", typeof(Client)),
            };

            return result;
        }
    }

    public class User
    {
    }

    public class RemoteUser
    {
    }
}
