using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using svietnamAPI.Common.Dtos.Responses;
using svietnamAPI.Common.Dtos.Values;
using System.Linq;

namespace svietnamAPI.Controllers.Filters
{
    public class ValidateFilterAttribute : ResultFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            base.OnResultExecuting(context);

            //model valid not pass  
            if (!context.ModelState.IsValid)
            {
                var ModelState = context.ModelState;
                var messages = new List<string>();

                //modify the result  
                var res = new ErrorResponse(10001, ResponseCodeConst.E10001, null, null);
                res.Messages.AddRange(messages);
                context.Result = new OkObjectResult(res);
            }
        }
    }
}