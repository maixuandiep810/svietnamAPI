using svietnamAPI.Models.IUnitOfWorks;
using svietnamAPI.Models.IServices;
using AutoMapper;
using Microsoft.Extensions.Logging;
using svietnamAPI.Models.IServices.Catalog;
using svietnamAPI.Models.Services.Catalog;
using System;

namespace svietnamAPI.Models.Services
{
    public class ServiceWrapper : IServiceWrapper
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceProvider _serviceProvider;
        private readonly IMapper _mapper;

        //
        //
        //  Catalog
        //
        //
        private ICategoryService _categoryService { get; set; }
        private IProductService _productService { get; set; }

        //
        //
        //  Catalog
        //
        //
        public ICategoryService CategoryService
        {
            get
            {
                if (_categoryService == null)
                {
                    var loggerCategoryService = (ILogger<CategoryService>)_serviceProvider.GetService(typeof(ILogger<CategoryService>));
                    _categoryService = new CategoryService(_mapper, _unitOfWork, this, loggerCategoryService);
                }
                return _categoryService;
            }
        }

        public IProductService ProductService
        {
            get
            {
                if (_productService == null)
                {
                    var loggerProductService = (ILogger<ProductService>)_serviceProvider.GetService(typeof(ILogger<ProductService>));
                    _productService = new ProductService(_mapper, _unitOfWork, this, loggerProductService);
                }
                return _productService;
            }
        }

        public ServiceWrapper(IUnitOfWork unitOfWork, IServiceProvider serviceProvider, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _serviceProvider = serviceProvider;
            _mapper = mapper;
        }
    }
}