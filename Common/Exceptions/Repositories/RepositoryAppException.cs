using System;
using System.Collections.Generic;
using System.Reflection;

namespace svietnamAPI.Common.Exceptions.Repositories
{
    public class RepositoryAppException : BaseAppException
    {
        public RepositoryAppException(string message) : base(message)
        {
        }

        public RepositoryAppException(List<string> messages) : base(messages)
        {
        }

        public RepositoryAppException(Exception ex) : base(ex)
        {
        }
    }
}