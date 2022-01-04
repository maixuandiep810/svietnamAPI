using System.Collections.Generic;
namespace svietnamAPI.Common.Dtos.Responses
{
    public class SuccessResponse<T>
    {
        public int Code { get; set; }
        public const bool IsSuccess = true;
        public T Data { get; set; }
        public List<string> Messages { get; set; }

        public SuccessResponse(int code, T data, string message)
        {
            Code = code;
            Data = data;
            Messages = new List<string>(new string[] { message });
        }

        public SuccessResponse(int code, T data, List<string> messages)
        {
            Code = code;
            Data = data;
            Messages = messages;
        }
    }
}