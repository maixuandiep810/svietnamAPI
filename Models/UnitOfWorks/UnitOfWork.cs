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
        private ICategoryDbRepository _categoryDbRepo { get; set; }
        private IProductDbRepository _productDbRepo { get; set; }

        //
        //
        //  Catalog
        //
        //
        public ICategoryDbRepository CategoryDbRepo
        {
            get
            {
                if (_categoryDbRepo == null)
                {
                    var loggerCategoryRepo = (ILogger<CategoryDbRepository>)_serviceProvider.GetService(typeof(ILogger<CategoryDbRepository>));
                    // var validatorCategory = (IValidator<Category>)_serviceProvider.GetService(typeof(IValidator<Category>));
                    _categoryDbRepo = new CategoryDbRepository(_appDbContext, null, _mapper, loggerCategoryRepo);
                }
                return _categoryDbRepo;
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