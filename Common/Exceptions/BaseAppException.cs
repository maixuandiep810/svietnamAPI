using System.Collections.Generic;
using System;

namespace svietnamAPI.Common.Exceptions
{
    public class BaseAppException : Exception
    {
        public List<string> Messages { get; set; }

        public BaseAppException(Exception ex) : base()
        {
            Messages = new List<string>(new string[] { ex.Message });
        }

        public BaseAppException(string message) : base()
        {
            Messages = new List<string>(new string[] { message });
        }

        public BaseAppException(List<string> messages) : base()
        {
            Messages = messages;
        }
    }
}