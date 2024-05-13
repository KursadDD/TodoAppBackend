using NTierToDoApp.EntityLayer.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace NTierToDoApp.EntityLayer.Concrete
{
    public class Member : BaseEntity
    {
        [MaxLength(50)]
        public string Name { get; set; }
        
        [MaxLength(100)]
        public string Surname { get; set; }
        
        [EmailAddress]
        public string EMail { get; set; }

        public int? TeamId { get; set; }
        public virtual Team Team { get; set; }
        public bool IsTeamLead { get; set; } = false;
    }
}
