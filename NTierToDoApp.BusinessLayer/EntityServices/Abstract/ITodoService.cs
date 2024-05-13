using NTierToDoApp.BusinessLayer.GenericServices;
using NTierToDoApp.EntityLayer.Concrete;
using NTierToDoApp.EntityLayer.Dtos;

namespace NTierToDoApp.BusinessLayer.EntityServices.Abstract
{
    public interface ITodoService : IService<Todo>
    {
        Task AddTodoAsync(TodoCreateDto todoCreateDto);
        Task UpdateTodoAsync(TodoUpdateDto todoUpdateDto);
    }
}
