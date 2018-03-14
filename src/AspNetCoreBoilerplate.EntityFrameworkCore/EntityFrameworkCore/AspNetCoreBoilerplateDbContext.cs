using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AspNetCoreBoilerplate.Authorization.Roles;
using AspNetCoreBoilerplate.Authorization.Users;
using AspNetCoreBoilerplate.MultiTenancy;

namespace AspNetCoreBoilerplate.EntityFrameworkCore
{
    public class AspNetCoreBoilerplateDbContext : AbpZeroDbContext<Tenant, Role, User, AspNetCoreBoilerplateDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AspNetCoreBoilerplateDbContext(DbContextOptions<AspNetCoreBoilerplateDbContext> options)
            : base(options)
        {
        }
    }
}
