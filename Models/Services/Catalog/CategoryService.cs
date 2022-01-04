using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using svietnamAPI.Infras.Data.DatabaseContext;
using svietnamAPI.Models.IRepositories;
using svietnamAPI.Infras.Data.DatabaseContext.Entities;
using svietnamAPI.Common.Exceptions.Repositories;
using System.Linq;
using svietnamAPI.Models.IServices;
using svietnamAPI.Models.IUnitOfWorks;
using svietnamAPI.Models.IServices.Catalog;
using svietnamAPI.Models.IRepositories.Catalog;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;
using svietnamAPI.Common.Dtos.Catalog;

namespace svietnamAPI.Models.Services.Catalog
{
    public class CategoryService : GenericService<Category, int, ICategoryDbRepository>, ICategoryService
    {
        public CategoryService(IMapper mapper, IUnitOfWork unitOfWork, IServiceWrapper serviceWrapper, ILogger logger)
        : base(mapper, unitOfWork, unitOfWork.CategoryDbRepo, serviceWrapper, logger)
        {

        }

        public async Task<List<TDto>> GetAllAsync<TDto>(bool isIncludeImage)
            where TDto : class
        {
            var entites = await _tDbRepo.GetAllAsync(isIncludeImage: true);
            var dtos = _mapper.Map<List<TDto>>(entites);
            return dtos;
        }

        public async Task CreateAsync(CreateCategoryDto createCategoryDto)
        {
            var createCategoryEntity = _mapper.Map<CreateCategoryDto, Category>(createCategoryDto);
            createCategoryEntity = _mapper.Map<DefaultFieldCategoryDto, Category>(new DefaultFieldCategoryDto(), createCategoryEntity);
            await _unitOfWork.CategoryDbRepo.InsertAsync(createCategoryEntity);
            await _unitOfWork.CommitAsync();
        }

        public async Task SoftDeleteAsync(int entityId)
        {
            await SoftDeleteAsync(entityId);
        }
    }
}