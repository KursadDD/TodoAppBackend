using NTierToDoApp.BusinessLayer.EntityServices.Abstract;
using NTierToDoApp.BusinessLayer.GenericServices;
using NTierToDoApp.DataAccessLayer.Concrete;
using NTierToDoApp.EntityLayer.Concrete;
using NTierToDoApp.EntityLayer.Dtos;

namespace NTierToDoApp.BusinessLayer.EntityServices.Concrete
{
    public class TodoSevice : Service<Todo>, ITodoService
    {
        public TodoSevice(NTierToDoAppDbContext context) : base(context)
        {
        }

        public async Task AddTodoAsync(TodoCreateDto todoCreateDto)
        {
            Todo todo = new();
            todo.Title = todoCreateDto.Title;
            todo.Content = todoCreateDto.Content;
            todo.StartDate = todoCreateDto.StartDate;
            todo.DueDate = todoCreateDto.DueDate;
            if (todoCreateDto.MemberId > 0)
                todo.MemberId = todoCreateDto.MemberId;

            await AddAsync(todo);
            await SaveAsync();
        }

        public async Task UpdateTodoAsync(TodoUpdateDto todoUpdateDto)
        {
            Todo todo = GetById(todoUpdateDto.Id);
            if (todo == null)
                return;
            todo.Title = todoUpdateDto.Title;
            todo.Content = todoUpdateDto.Content;
            todo.StartDate = todoUpdateDto.StartDate;
            todo.DueDate = todoUpdateDto.DueDate;
            if (todoUpdateDto.MemberId > 0) todo.MemberId = todoUpdateDto.MemberId;
            todo.IsCompleted = todoUpdateDto.IsCompleted;
            if (todoUpdateDto.IsCompleted)
                todo.ComlatedDate = DateTime.Now;

            Update(todo);
            _ = SaveAsync();
        }
    }
}
