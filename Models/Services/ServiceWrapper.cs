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
        private IGlobalProductCategoryService _globalProductCategoryService { get; set; }
        private IProductService _productService { get; set; }

        //
        //
        //  Catalog
        //
        //
        public IGlobalProductCategoryService GlobalProductCategoryService
        {
            get
            {
                if (_globalProductCategoryService == null)
                {
                    var loggerGlobalProductCategoryService = (ILogger<GlobalProductCategoryService>)_serviceProvider.GetService(typeof(ILogger<GlobalProductCategoryService>));
                    _globalProductCategoryService = new GlobalProductCategoryService(_mapper, _unitOfWork, this, loggerGlobalProductCategoryService);
                }
                return _globalProductCategoryService;
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