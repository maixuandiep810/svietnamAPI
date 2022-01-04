using System;
using System.Collections.Generic;
using System.Reflection;

namespace svietnamAPI.Common.Exceptions.Controllers
{
    public class RequestDtoValidationFailedAppException : BaseAppException
    {
        public RequestDtoValidationFailedAppException(string message) : base(message)
        {
        }

        public RequestDtoValidationFailedAppException(List<string> messages) : base(messages)
        {
        }

        public RequestDtoValidationFailedAppException(Exception ex) : base(ex)
        {
        }
    }
}