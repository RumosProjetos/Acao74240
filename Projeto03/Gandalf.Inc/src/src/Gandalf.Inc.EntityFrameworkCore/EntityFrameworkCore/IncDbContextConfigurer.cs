using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Gandalf.Inc.EntityFrameworkCore
{
    public static class IncDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<IncDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<IncDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
