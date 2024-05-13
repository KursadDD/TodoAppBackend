using Microsoft.AspNetCore.Mvc;
using NTierToDoApp.BusinessLayer.EntityServices.Abstract;
using NTierToDoApp.EntityLayer.Dtos;

namespace NTierToDoApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly ITeamService _teamService;
        public TeamsController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var result = _teamService.GetById(id);
            return Ok(result);
        }

        [HttpGet]
        [Route("getList")]
        public IActionResult GetList()
        {
            var result = _teamService.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public async Task AddTeam(TeamCreateDto teamCreateDto)
        {
          await _teamService.AddTeamAsync(teamCreateDto);
        }

        [HttpPut]
        public async Task UpdateTeam(TeamUpdateDto teamUpdateDto)
        {
            await _teamService.UpdateTeamAsync(teamUpdateDto);
        }

        [HttpDelete]
        public async Task DeleteTeam(int Id)
        {
            _teamService.DeleteById(Id);
            await _teamService.SaveAsync();
        }

    }
}
