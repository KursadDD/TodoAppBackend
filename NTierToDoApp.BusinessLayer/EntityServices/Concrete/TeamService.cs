using NTierToDoApp.BusinessLayer.EntityServices.Abstract;
using NTierToDoApp.BusinessLayer.GenericServices;
using NTierToDoApp.DataAccessLayer.Concrete;
using NTierToDoApp.EntityLayer.Concrete;
using NTierToDoApp.EntityLayer.Dtos;

namespace NTierToDoApp.BusinessLayer.EntityServices.Concrete
{
    public class TeamService : Service<Team>, ITeamService
    {
        public TeamService(NTierToDoAppDbContext context) : base(context)
        {
        }

        public async Task AddTeamAsync(TeamCreateDto teamCreateDto)
        {
            Team team = new();
            team.Name = teamCreateDto.Name;
            team.Description = teamCreateDto.Description;

            await AddAsync(team);
            await SaveAsync();
        }

        public async Task UpdateTeamAsync(TeamUpdateDto teamUpdateDto)
        {
            Team team = GetById(teamUpdateDto.Id);
            if (team == null)
                return;
            team.Name = teamUpdateDto.Name;
            team.Description = teamUpdateDto.Description;

            Update(team);
            _ = SaveAsync();
        }
    }
}
