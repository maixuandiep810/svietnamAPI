using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Logging;
using svietnamAPI.Models.IRepositories;
using svietnamAPI.Infras.Data.DatabaseContext.Entities;
using svietnamAPI.Models.IServices;
using svietnamAPI.Models.IUnitOfWorks;

namespace svietnamAPI.Models.Services
{
    public abstract partial class GenericService<TEntity, TId, TDbRepo> : IGenericService<TEntity, TId>
    where TId : struct
    where TEntity : class, IBaseEntity<TId>
    where TDbRepo : IGenericDbRepository<TEntity, TId>
    {
        protected readonly IMapper _mapper;
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly TDbRepo _tDbRepo;
        protected readonly IServiceWrapper _serviceWrapper;
        protected readonly ILogger _logger;

        public GenericService(IMapper mapper, IUnitOfWork unitOfWork, TDbRepo tRepo, IServiceWrapper serviceWrapper, ILogger logger)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _tDbRepo = tRepo;
            _serviceWrapper = serviceWrapper;
            _logger = logger;
        }

        public async Task<List<TDto>> GetAllAsync<TDto>()
        where TDto : class
        {
            var entities = await _tDbRepo.GetAllAsync();
            var dtos = _mapper.Map<List<TEntity>, List<TDto>>(entities);
            return dtos;
        }

        public async Task<TDto> GetByIdAsync<TDto>(TId id)
        where TDto : class
        {
            var entity = await _tDbRepo.GetByIdAsync(id);
            var dto = _mapper.Map<TEntity, TDto>(entity);
            return dto;
        }
    }
}