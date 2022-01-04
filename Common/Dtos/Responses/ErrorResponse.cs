using System.Collections.Generic;
namespace svietnamAPI.Common.Dtos.Responses
{
    public class ErrorResponse
    {
        public int Code { get; set; }
        public const bool IsSuccess = false; 
        public List<string> Messages { get; set; }
        public string StackTrace { get; set; }
        public string ExceptionMessage { get; set; }

        public ErrorResponse(int code, string message, string stackTrace, string exceptionMessage)
        {
            Code = code;
            Messages = new List<string>(new string[] { message });
            StackTrace = stackTrace;
            ExceptionMessage = exceptionMessage;
        }

        public ErrorResponse(int code, List<string> messages, string stackTrace, string exceptionMessage)
        {
            Code = code;
            Messages = messages;
            StackTrace = stackTrace;
            ExceptionMessage = exceptionMessage;
        }
    }
}