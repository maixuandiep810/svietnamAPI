using svietnamAPI.Models.IServices.Catalog;
using svietnamAPI.Models.Services.Catalog;

namespace svietnamAPI.Models.IServices
{
    public interface IServiceWrapper
    {
        ICategoryService CategoryService { get; }
    }
}