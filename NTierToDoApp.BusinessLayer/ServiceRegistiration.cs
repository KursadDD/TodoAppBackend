using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NTierToDoApp.BusinessLayer.EntityServices.Abstract;
using NTierToDoApp.BusinessLayer.EntityServices.Concrete;
using NTierToDoApp.DataAccessLayer.Concrete;

namespace NTierToDoApp.BusinessLayer
{
    public static class ServiceRegistiration
    {

        public static void AddPersistanceServices(this IServiceCollection services)
        {
            services.AddDbContext<NTierToDoAppDbContext>(options => 
            options.UseSqlServer(Configuration.ConnectionString));
            
            services.AddScoped<IMemberService, MemberService>();
            services.AddScoped<ITeamService, TeamService>();
            services.AddScoped<ITodoService, TodoSevice>();
        }
    }
}
