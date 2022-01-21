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
    public abstract partial class GenericService<TEntity, TId, TDbRepo, TDto> : IGenericService<TEntity, TId, TDto>
    where TId : struct
    where TEntity : class, IBaseEntity<TId>, new()
    where TDbRepo : IGenericDbRepository<TEntity, TId>
    where TDto : class, new()
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

        public async Task<List<TDto>> GetBasicAllOrNullAsync()
        {
            var entities = await _tDbRepo.GetBasicAllOrNullAsync();
            var dtos = _mapper.Map<List<TEntity>, List<TDto>>(entities);
            return dtos;
        }

        public async Task<TDto> GetBasicByIdOrNullAsync(TId id)
        {
            var entity = await _tDbRepo.GetBasicByIdOrNullAsync(id);
            var dto = _mapper.Map<TEntity, TDto>(entity);
            return dto;
        }
    }
}