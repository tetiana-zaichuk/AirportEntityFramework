using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<TEntity> Set<TEntity>() where TEntity : Entity;

        int SaveChages();

        Task<int> SaveChangesAsync();
    }
}
