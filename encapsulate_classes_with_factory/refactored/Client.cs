using System;
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
                new DefaultDescriptor("createdDate", typeof(Client), typeof(DateTime)),
                new DefaultDescriptor("lastChangedDate", typeof(Client), typeof(DateTime)),
                new ReferenceDescriptor("createdBy", typeof(Client), typeof(User), typeof(RemoteUser)),
                new ReferenceDescriptor("lastChangedBy", typeof(Client), typeof(User), typeof(RemoteUser)),
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
