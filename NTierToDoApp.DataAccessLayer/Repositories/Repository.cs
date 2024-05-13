using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using NTierToDoApp.DataAccessLayer.Concrete;
using NTierToDoApp.EntityLayer.Entities.Common;

namespace NTierToDoApp.DataAccessLayer.GenericRepositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly NTierToDoAppDbContext _context;

        public Repository(NTierToDoAppDbContext context)
        {
            _context = context;
        }

        public DbSet<TEntity> Table => _context.Set<TEntity>();

        public IQueryable<TEntity> GetAll()
        {
            return Table.Where(w => !w.IsDeleted);
        }

        public TEntity GetById(int id)
        {
            return Table.FirstOrDefault(f => f.Id == id && !f.IsDeleted);
        }

        public async Task<bool> AddAsync(TEntity entity)
        {
            EntityEntry<TEntity> entityEntr = await Table.AddAsync(entity);
            return entityEntr.State == EntityState.Added;
        }

        public bool Delete(TEntity entity)
        {
            entity.DeletedDate = DateTime.Now;
            entity.IsDeleted = true;
            EntityEntry<TEntity> entityEntr = Table.Update(entity);
            return entityEntr.State == EntityState.Modified;
        }

        public bool DeleteById(int id)
        {

            TEntity entity = Table.FirstOrDefault(f => f.Id == id && !f.IsDeleted);
            if (entity != null)
                return Delete(entity);
            return false;
        }

        public bool Update(TEntity entity)
        {
            entity.EditedDate = DateTime.Now;
            EntityEntry<TEntity> entityEntr = Table.Update(entity);
            return entityEntr.State == EntityState.Modified;
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
