using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreBoilerplate.EntityFrameworkCore
{
    public static class AspNetCoreBoilerplateDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AspNetCoreBoilerplateDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AspNetCoreBoilerplateDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
