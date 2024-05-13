using NTierToDoApp.DataAccessLayer.Concrete;
using NTierToDoApp.DataAccessLayer.GenericRepositories;
using NTierToDoApp.EntityLayer.Entities.Common;

namespace NTierToDoApp.BusinessLayer.GenericServices
{
    public class Service<TEntity> : Repository<TEntity>, IService<TEntity> where TEntity : BaseEntity
    {
        public Service(NTierToDoAppDbContext context) : base(context)
        {
        }
    }
}
