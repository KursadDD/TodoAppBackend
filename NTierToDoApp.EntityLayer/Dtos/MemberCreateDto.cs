﻿using NTierToDoApp.EntityLayer.Concrete;

namespace NTierToDoApp.EntityLayer.Dtos
{
    public class MemberCreateDto
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string EMail { get; set; }

        public int? TeamId { get; set; }
        public bool IsTeamLead { get; set; } = false;
    }
}
