using System;
using System.Collections.Generic;
using System.Reflection;

namespace svietnamAPI.Common.Exceptions.Repositories
{
    public class NotFoundEntityAppException : BaseAppException
    {
        public NotFoundEntityAppException(string message) : base(message)
        {

        }

        public NotFoundEntityAppException(List<string> messages) : base(messages)
        {
        }

        public NotFoundEntityAppException(Exception ex) : base(ex)
        {
        }
    }
}