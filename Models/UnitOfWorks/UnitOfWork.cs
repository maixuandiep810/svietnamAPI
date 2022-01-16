using System;
using System.Threading.Tasks;
using svietnamAPI.Infras.Data.DatabaseContext;
using svietnamAPI.Models.IUnitOfWorks;
using svietnamAPI.Models.IRepositories.Catalog;
using svietnamAPI.Models.Repositories.Catalog;
using AutoMapper;
using Microsoft.Extensions.Logging;
using FluentValidation;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;

namespace svietnamAPI.Models.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool disposed = false;
        private readonly AppDbContext _appDbContext;
        private readonly IServiceProvider _serviceProvider;
        private readonly IMapper _mapper;

        //
        //
        //  Catalog
        //
        //
        private IGlobalProductCategoryDbRepository _globalProductCategoryDbRepo { get; set; }
        private IProductDbRepository _productDbRepo { get; set; }

        //
        //
        //  Catalog
        //
        //
        public IGlobalProductCategoryDbRepository GlobalProductCategoryDbRepo
        {
            get
            {
                if (_globalProductCategoryDbRepo == null)
                {
                    var loggerGlobalProductCategoryDbRepo = (ILogger<GlobalProductCategoryDbRepository>)_serviceProvider.GetService(
                        typeof(ILogger<GlobalProductCategoryDbRepository>));
                    // var validatorCategory = (IValidator<Category>)_serviceProvider.GetService(typeof(IValidator<Category>));
                    _globalProductCategoryDbRepo = new GlobalProductCategoryDbRepository(_appDbContext, null, _mapper, loggerGlobalProductCategoryDbRepo);
                }
                return _globalProductCategoryDbRepo;
            }
        }

        public IProductDbRepository ProductDbRepo
        {
            get
            {
                if (_productDbRepo == null)
                {
                    var loggerProductRepo = (ILogger<ProductDbRepository>)_serviceProvider.GetService(typeof(ILogger<ProductDbRepository>));
                    // var validatorCategory = (IValidator<Category>)_serviceProvider.GetService(typeof(IValidator<Category>));
                    _productDbRepo = new ProductDbRepository(_appDbContext, null, _mapper, loggerProductRepo);
                }
                return _productDbRepo;
            }
        }

        //
        //
        //
        //
        //
        public UnitOfWork(AppDbContext appDbContext, IServiceProvider serviceProvider, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _serviceProvider = serviceProvider;
            _mapper = mapper;
        }

        public async Task CommitAsync()
        {
            await _appDbContext.SaveChangesAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed && disposing)
            {
                _appDbContext.Dispose();
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}