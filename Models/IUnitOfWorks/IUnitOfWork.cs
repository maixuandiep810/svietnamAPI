using System.Threading.Tasks;
using svietnamAPI.Models.IRepositories.Catalog;
using svietnamAPI.Models.Repositories.Catalog;

namespace svietnamAPI.Models.IUnitOfWorks
{
    public interface IUnitOfWork
    {
        ICategoryDbRepository CategoryDbRepo { get; }
        IProductDbRepository ProductDbRepo { get; }
        Task CommitAsync();
    }
}