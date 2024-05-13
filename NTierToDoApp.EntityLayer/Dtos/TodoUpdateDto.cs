using NTierToDoApp.EntityLayer.Concrete;

namespace NTierToDoApp.EntityLayer.Dtos
{
    public class TodoUpdateDto
    {
        public int Id { get; init; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime? ComlatedDate { get; set; }
        public int? MemberId { get; set; }
    }
}
