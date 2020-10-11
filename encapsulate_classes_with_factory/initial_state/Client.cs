using System;
using System.Collections.Generic;
using encapsulate_classes_with_factory.initial_state.descriptors;

namespace encapsulate_classes_with_factory.initial_state
{
    public class Client
    {
        public static List<AttributeDescriptor> CreateAttributeDescriptors()
        {
            List<AttributeDescriptor> result = new List<AttributeDescriptor>();

            result.Add(new DefaultDescriptor("remoteId", typeof(Client), typeof(int)));
            result.Add(new DefaultDescriptor("crea tedDate", typeof(Client), typeof(DateTime)));
            result.Add(new DefaultDescriptor("lastChangedDate", typeof(Client), typeof(DateTime)));
            result.Add(new ReferenceDescriptor("createdBy", typeof(Client), typeof(User), typeof(RemoteUser)));
            result.Add(new ReferenceDescriptor("lastChangedBy", typeof(Client), typeof(User), typeof(RemoteUser)));
            result.Add(new DefaultDescriptor("optimisticLockVersion", typeof(Client), typeof(int)));

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
