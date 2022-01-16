using System.Threading.Tasks;
using svietnamAPI.Models.IRepositories.Catalog;
using svietnamAPI.Models.Repositories.Catalog;

namespace svietnamAPI.Models.IUnitOfWorks
{
    public interface IUnitOfWork
    {
        IGlobalProductCategoryDbRepository GlobalProductCategoryDbRepo { get; }
        IProductDbRepository ProductDbRepo { get; }
        Task CommitAsync();
    }
}