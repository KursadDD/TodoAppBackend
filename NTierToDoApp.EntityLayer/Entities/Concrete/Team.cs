using NTierToDoApp.EntityLayer.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace NTierToDoApp.EntityLayer.Concrete
{
    public class Team : BaseEntity
    {
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }
    }
}
