using NTierToDoApp.BusinessLayer.GenericServices;
using NTierToDoApp.EntityLayer.Concrete;
using NTierToDoApp.EntityLayer.Dtos;

namespace NTierToDoApp.BusinessLayer.EntityServices.Abstract
{
    public interface ITeamService : IService<Team>
    {
        Task AddTeamAsync(TeamCreateDto teamCreateDto);
        Task UpdateTeamAsync(TeamUpdateDto teamUpdateDto);
    }
}
