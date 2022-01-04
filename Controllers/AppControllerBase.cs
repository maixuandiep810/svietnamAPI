using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using svietnamAPI.Models.IServices;

namespace svietnamAPI.Controllers
{
    public abstract class AppControllerBase : ControllerBase
    {
        protected readonly IServiceWrapper _serviceWrapper;
        protected readonly ILogger _logger;
        public AppControllerBase(IServiceWrapper serviceWrapper, ILogger logger)
        {
            _serviceWrapper = serviceWrapper;
            _logger = logger;
        }
    }
}