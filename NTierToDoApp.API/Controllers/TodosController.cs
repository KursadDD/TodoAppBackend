using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NTierToDoApp.BusinessLayer.EntityServices.Abstract;
using NTierToDoApp.BusinessLayer.EntityServices.Concrete;
using NTierToDoApp.EntityLayer.Dtos;

namespace NTierToDoApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoService _todoService;

        public TodosController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var result = _todoService.GetById(id);
            return Ok(result);
        }

        [HttpGet]
        [Route("getByIdWithMember")]
        public IActionResult GetByIdWithMember(int id)
        {
            var result = _todoService.GetAll()
                                     .Include(m=>m.Member)
                                        .ThenInclude(t=>t.Team)
                                     .FirstOrDefault(t=>t.Id == id);
            return Ok(result);
        }
        [HttpGet]
        [Route("getList")]
        public IActionResult GetList()
        {
            var result = _todoService.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public async Task AddTeam(TodoCreateDto todoCreateDto)
        {
            await _todoService.AddTodoAsync(todoCreateDto);
        }

        [HttpPut]
        public async Task UpdateTeam(TodoUpdateDto todoUpdateDto)
        {
            await _todoService.UpdateTodoAsync(todoUpdateDto);
        }

        [HttpDelete]
        public async Task DeleteTeam(int Id)
        {
            _todoService.DeleteById(Id);
            await _todoService.SaveAsync();
        }
    }
}
