using NTierToDoApp.DataAccessLayer.GenericRepositories;
using NTierToDoApp.EntityLayer.Entities.Common;

namespace NTierToDoApp.BusinessLayer.GenericServices
{
    public interface IService<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
    }
}
