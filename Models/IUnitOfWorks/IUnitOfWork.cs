using System.Threading.Tasks;
using svietnamAPI.Models.IRepositories.AppStaticFile;
using svietnamAPI.Models.IRepositories.Catalog;
using svietnamAPI.Models.IRepositories.Core;
using svietnamAPI.Models.Repositories.Catalog;

namespace svietnamAPI.Models.IUnitOfWorks
{
    public interface IUnitOfWork
    {
        IStaticFileRepository StaticFileRepo { get; }

        IGlobalProductCategoryDbRepository GlobalProductCategoryDbRepo { get; }
        IProductDbRepository ProductDbRepo { get; }
        IEntityStatusDbRepository EntityStatusDbRepo { get; }
        
        Task CommitAsync();
    }
}