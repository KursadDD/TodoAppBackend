using NTierToDoApp.BusinessLayer.EntityServices.Abstract;
using NTierToDoApp.BusinessLayer.GenericServices;
using NTierToDoApp.DataAccessLayer.Concrete;
using NTierToDoApp.EntityLayer.Concrete;
using NTierToDoApp.EntityLayer.Dtos;

namespace NTierToDoApp.BusinessLayer.EntityServices.Concrete
{
    public class MemberService : Service<Member>, IMemberService
    {
        public MemberService(NTierToDoAppDbContext context) : base(context)
        {
        }

        public async Task AddMemberAsync(MemberCreateDto memberCreateDto)
        {
            Member member = new();
            member.Name = memberCreateDto.Name;
            member.Surname = memberCreateDto.Surname;
            member.EMail = memberCreateDto.EMail;
            if (memberCreateDto.TeamId > 0)
                member.TeamId = memberCreateDto.TeamId;
            member.IsTeamLead = memberCreateDto.IsTeamLead;

            await AddAsync(member);
            await SaveAsync();
        }

        public async Task UpdateMemberAsync(MemberUpdateDto memberUpdateDto)
        {
            Member member = GetById(memberUpdateDto.Id);
            if (member == null)
                return;
            member.Name = memberUpdateDto.Name;
            member.Surname = memberUpdateDto.Surname;
            member.EMail = memberUpdateDto.EMail;
            if (memberUpdateDto.TeamId > 0)
                member.TeamId = memberUpdateDto.TeamId;
            member.IsTeamLead = memberUpdateDto.IsTeamLead;

            Update(member);
            _ = SaveAsync();
        }
    }
}
