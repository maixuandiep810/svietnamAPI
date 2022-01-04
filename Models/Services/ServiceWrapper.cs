using svietnamAPI.Models.IUnitOfWorks;
using svietnamAPI.Models.IServices;
using AutoMapper;
using Microsoft.Extensions.Logging;
using svietnamAPI.Models.IServices.Catalog;
using svietnamAPI.Models.Services.Catalog;

namespace svietnamAPI.Models.Services
{
    public class ServiceWrapper : IServiceWrapper
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILoggerFactory _loggerFactory;

        private ICategoryService _categoryService { get; set; }

        public ICategoryService CategoryService
        {
            get
            {
                if (_categoryService == null)
                {
                    var loggerCategoryService = _loggerFactory.CreateLogger<CategoryService>();
                    _categoryService = new CategoryService(_mapper, _unitOfWork, this, loggerCategoryService);
                }
                return _categoryService;
            }
        }

        public ServiceWrapper(IUnitOfWork unitOfWork, IMapper mapper, ILoggerFactory loggerFactory)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _loggerFactory = loggerFactory;
        }
    }
}