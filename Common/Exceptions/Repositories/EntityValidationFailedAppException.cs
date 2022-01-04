using System.Collections.Generic;
using System;
using System.Reflection;

namespace svietnamAPI.Common.Exceptions.Repositories
{
    public class EntityValidationFailedAppException : BaseAppException
    {
        public EntityValidationFailedAppException(string message) : base(message)
        {
        }
        
        public EntityValidationFailedAppException(List<string> messages) : base(messages)
        {
        }

        public EntityValidationFailedAppException(Exception ex) : base(ex)
        {
        }
    }
}