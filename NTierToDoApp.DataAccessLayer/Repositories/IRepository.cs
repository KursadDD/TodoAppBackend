using Microsoft.EntityFrameworkCore;
using NTierToDoApp.EntityLayer.Entities.Common;

namespace NTierToDoApp.DataAccessLayer.GenericRepositories
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        DbSet<TEntity> Table { get; }
        IQueryable<TEntity> GetAll();
        TEntity GetById(int id);
        Task<bool> AddAsync(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
        bool DeleteById(int id);
        Task<int> SaveAsync();
    }
}
