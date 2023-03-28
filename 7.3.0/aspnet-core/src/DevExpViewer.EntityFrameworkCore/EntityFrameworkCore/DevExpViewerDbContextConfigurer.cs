using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace DevExpViewer.EntityFrameworkCore
{
    public static class DevExpViewerDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DevExpViewerDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DevExpViewerDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
