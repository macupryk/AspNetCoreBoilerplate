using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AspNetCoreBoilerplate.Configuration;
using AspNetCoreBoilerplate.Web;

namespace AspNetCoreBoilerplate.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AspNetCoreBoilerplateDbContextFactory : IDesignTimeDbContextFactory<AspNetCoreBoilerplateDbContext>
    {
        public AspNetCoreBoilerplateDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AspNetCoreBoilerplateDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AspNetCoreBoilerplateDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AspNetCoreBoilerplateConsts.ConnectionStringName));

            return new AspNetCoreBoilerplateDbContext(builder.Options);
        }
    }
}
