using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NTierToDoApp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierToDoApp.DataAccessLayer.Concrete
{
    public class NTierToDoAppDbContext : DbContext
    {
        public NTierToDoAppDbContext(DbContextOptions options) : base(options) { }


        public DbSet<Team> Team { get; set; }
        public DbSet<Todo> Todo { get; set; }
        public DbSet<Member> Member { get; set; }
    }
}
 