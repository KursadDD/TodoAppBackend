namespace NTierToDoApp.EntityLayer.Entities.Common
{
    public class BaseEntity
    {
        public int Id { get; init; }
        public DateTime CreatedDate { get; init; } = DateTime.Now;
        public DateTime? EditedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedDate { get; set; }

    }
}
