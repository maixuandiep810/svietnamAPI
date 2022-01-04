using System;
using System.Reflection;

namespace svietnamAPI.Common.Exceptions
{
    public class UncategorizedErrorAppException : Exception
    {
        public UncategorizedErrorAppException(string message) : base(message) { }

        public UncategorizedErrorAppException(Exception ex) : base()
        {
            var stackTraceField = typeof(UncategorizedErrorAppException)
                .BaseType
                .GetField("_stackTraceString", BindingFlags.Instance | BindingFlags.NonPublic);
            stackTraceField.SetValue(this, ex.StackTrace);
        }
    }
}