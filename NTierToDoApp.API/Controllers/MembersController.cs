using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NTierToDoApp.BusinessLayer.EntityServices.Abstract;
using NTierToDoApp.BusinessLayer.EntityServices.Concrete;
using NTierToDoApp.EntityLayer.Dtos;

namespace NTierToDoApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly IMemberService _memberService;

        public MembersController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var result = _memberService.GetById(id);
            return Ok(result);
        }
        
        [HttpGet]
        [Route("getList")]
        public IActionResult GetList()
        {
            var result = _memberService.GetAll();
            return Ok(result);
        }

        [HttpGet]
        [Route("getListWithTeam")]
        public IActionResult GetListWithTeam()
        {
            var result = _memberService.GetAll().Include(I=>I.Team);
            return Ok(result);
        }

        [HttpGet]
        [Route("getListByTeamId")]
        public IActionResult getListByTeamId(int id)
        {
            var result = _memberService.GetAll().Where(w=>w.TeamId == id);
            return Ok(result);
        }

        [HttpPost]
        public async Task AddTeam(MemberCreateDto memberCreateDto)
        {
            await _memberService.AddMemberAsync(memberCreateDto);
        }

        [HttpPut]
        public async Task UpdateTeam(MemberUpdateDto memberUpdateDto)
        {
            await _memberService.UpdateMemberAsync(memberUpdateDto);
        }

        [HttpDelete]
        public async Task DeleteTeam(int Id)
        {
            _memberService.DeleteById(Id);
            await _memberService.SaveAsync();
        }
    }
}
