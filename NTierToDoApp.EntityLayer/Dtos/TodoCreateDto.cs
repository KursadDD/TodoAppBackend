using NTierToDoApp.EntityLayer.Concrete;

namespace NTierToDoApp.EntityLayer.Dtos
{
    public class TodoCreateDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public int? MemberId { get; set; }
    }
}
