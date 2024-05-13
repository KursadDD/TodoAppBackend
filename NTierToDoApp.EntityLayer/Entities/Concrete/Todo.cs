using NTierToDoApp.EntityLayer.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace NTierToDoApp.EntityLayer.Concrete
{
    public class Todo : BaseEntity
    {
        [MaxLength(100)]
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime? ComlatedDate { get; set; }
        public int? MemberId { get; set; }
        public virtual Member Member { get; set; }

    }
}
