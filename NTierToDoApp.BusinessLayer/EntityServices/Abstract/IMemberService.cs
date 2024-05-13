using NTierToDoApp.BusinessLayer.GenericServices;
using NTierToDoApp.EntityLayer.Concrete;
using NTierToDoApp.EntityLayer.Dtos;

namespace NTierToDoApp.BusinessLayer.EntityServices.Abstract
{
    public interface IMemberService : IService<Member> 
    {
        Task AddMemberAsync(MemberCreateDto memberCreateDto);
        Task UpdateMemberAsync(MemberUpdateDto memberUpdateDto);
    }
}
