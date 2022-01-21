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
using svietnamAPI.Models.IRepositories.Core;
using svietnamAPI.Models.Repositories.Core;
using svietnamAPI.Infras.Data.StaticFileContext;
using svietnamAPI.Models.IRepositories.AppStaticFile;
using svietnamAPI.Models.Repositories.AppStaticFile;

namespace svietnamAPI.Models.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool disposed = false;
        private readonly AppDbContext _appDbContext;
        private readonly AppStaticFileContext _appStaticFileContext;
        private readonly IServiceProvider _serviceProvider;
        private readonly IMapper _mapper;



        //
        //  StaticFile
        //

        private IStaticFileRepository _staticFileRepo { get; set; }

        //
        //  Catalog
        //

        private IGlobalProductCategoryDbRepository _globalProductCategoryDbRepo { get; set; }
        private IProductDbRepository _productDbRepo { get; set; }

        //
        //  Core
        //

        private IEntityStatusDbRepository _entityStatusDbRepo { get; set; }

        //
        //
        //
        //
        //
        //
        //
        //
        //
        //

        //
        //  StaticFile
        //

        public IStaticFileRepository StaticFileRepo
        {
            get
            {
                if (_staticFileRepo == null)
                {
                    var loggerStaticFileRepo = (ILogger<StaticFileRepository>)_serviceProvider.GetService(typeof(ILogger<StaticFileRepository>));
                    // var validatorCategory = (IValidator<Category>)_serviceProvider.GetService(typeof(IValidator<Category>));
                    _staticFileRepo = new StaticFileRepository(_appStaticFileContext, loggerStaticFileRepo);
                }
                return _staticFileRepo;
            }
        }

        //
        //  Catalog
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
        //  Core
        //

        public IEntityStatusDbRepository EntityStatusDbRepo
        {
            get
            {
                if (_entityStatusDbRepo == null)
                {
                    var loggerEntityStatusRepo = (ILogger<EntityStatusDbRepository>)_serviceProvider.GetService(typeof(ILogger<EntityStatusDbRepository>));
                    _entityStatusDbRepo = new EntityStatusDbRepository(_appDbContext, null, _mapper, loggerEntityStatusRepo);
                }
                return _entityStatusDbRepo;
            }
        }
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        public UnitOfWork(AppDbContext appDbContext, AppStaticFileContext appStaticFileContext, IServiceProvider serviceProvider, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _appStaticFileContext = appStaticFileContext;
            _serviceProvider = serviceProvider;
            _mapper = mapper;
        }

        public async Task CommitAsync()
        {
            try
            {
                await _appDbContext.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                // Step1. Rollback _appDbContext: auto rollback
                //

                // step2. Rollback _appStaticFileContext: 
                await _appStaticFileContext.RollBackWriteStaticFileAsync();
                throw;
            }
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