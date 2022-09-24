using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Gandalf.Inc.Authorization.Roles;
using Gandalf.Inc.Authorization.Users;
using Gandalf.Inc.MultiTenancy;

namespace Gandalf.Inc.EntityFrameworkCore
{
    public class IncDbContext : AbpZeroDbContext<Tenant, Role, User, IncDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public IncDbContext(DbContextOptions<IncDbContext> options)
            : base(options)
        {
        }
    }
}
