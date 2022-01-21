using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Logging;
using svietnamAPI.Models.IServices;
using svietnamAPI.Models.IUnitOfWorks;
using svietnamAPI.Models.IServices.Catalog;
using svietnamAPI.Models.IRepositories.Catalog;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;
using svietnamAPI.Common.Dtos.DtoToEntities.Catalog;
using svietnamAPI.Infras.Data.StaticFileContext;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;
using svietnamAPI.Common.Dtos.DtoToEntities.Core;

namespace svietnamAPI.Models.Services.Catalog
{
    public class GlobalProductCategoryService : GenericService<GlobalProductCategory, int, IGlobalProductCategoryDbRepository, GlobalProductCategoryDto>,
        IGlobalProductCategoryService
    {
        public GlobalProductCategoryService(IMapper mapper, IUnitOfWork unitOfWork, IServiceWrapper serviceWrapper, ILogger logger)
        : base(mapper, unitOfWork, unitOfWork.GlobalProductCategoryDbRepo, serviceWrapper, logger)
        {

        }

        public async Task<List<GlobalProductCategorySummaryDto>> GetSummaryAllOrNullAsync()
        {
            var globalPCDtos = await _tDbRepo.GetSummaryAllOrNullAsync();
            return globalPCDtos;
        }

        public async Task<GlobalProductCategorySummaryDto> GetSummaryByIdOrNullAsync(int gpcId)
        {
            var globalPCDto = await _tDbRepo.GetSummaryByIdOrNullAsync(gpcId);
            return globalPCDto;
        }

        public async Task<List<GlobalProductCategoryDto>> GetDetailAllOrNullAsync(bool shouldIncludeImage)
        {
            var globalPCEntites = await _tDbRepo.GetDetailAllOrNullAsync(shouldIncludeImage);
            var globalPCDtos = _mapper.Map<List<GlobalProductCategoryDto>>(globalPCEntites);
            return globalPCDtos;
        }

        public async Task<GlobalProductCategoryDto> GetDetailByIdOrNullAsync(int gpcId, 
            bool shouldIncludeImage)
        {
            var globalPCEntity = await _tDbRepo.GetDetailByIdOrNullAsync(gpcId, shouldIncludeImage);
            var globalPCDto = _mapper.Map<GlobalProductCategoryDto>(globalPCEntity);
            return globalPCDto;
        }

        public async Task CreateAsync(GlobalProductCategoryCreateDto createDto)
        {
            //
            var createEntity = _mapper.Map<GlobalProductCategoryCreateDto, GlobalProductCategory>(createDto);
            createEntity = _mapper.Map<GlobalProductCategoryDefaultFieldDto, GlobalProductCategory>(new GlobalProductCategoryDefaultFieldDto(), createEntity);
            if (createDto.BaseImage != null)
            {
                var baseImageCreateDto = await _unitOfWork.StaticFileRepo.WriteStaticFileAsync(RelativeLocationOfStaticFileFolderEnum.GlobalProductCategoryImage, createDto.BaseImage);
                var baseImageEntity = _mapper.Map<DocumentCreateDto, Document>(baseImageCreateDto,
                    _mapper.Map<DocumentDefaultFieldDto, Document>(new DocumentDefaultFieldDto())
                );
                createEntity.BaseImage = baseImageEntity;
            }
            if (createDto.ThumbnailImage != null)
            {
                var thumbnailImageCreateDto = await _unitOfWork.StaticFileRepo.WriteStaticFileAsync(RelativeLocationOfStaticFileFolderEnum.GlobalProductCategoryImage, createDto.ThumbnailImage);
                var thumbnailImageEntity = _mapper.Map<DocumentCreateDto, Document>(thumbnailImageCreateDto,
                    _mapper.Map<DocumentDefaultFieldDto, Document>(new DocumentDefaultFieldDto())
                );
                createEntity.ThumbnailImage = thumbnailImageEntity;
            }
            await _unitOfWork.GlobalProductCategoryDbRepo.InsertAsync(createEntity);
            await _unitOfWork.CommitAsync();
        }

        // public async Task SoftDeleteAsync(int gpcId)
        // {
        //     //TODO
        //     //1. ProductService - SoftDelete (PRDetail, PRItem... Services - SoftDelete)
        //     //2. DocumentService - SoftDelete
        // }
    }
}