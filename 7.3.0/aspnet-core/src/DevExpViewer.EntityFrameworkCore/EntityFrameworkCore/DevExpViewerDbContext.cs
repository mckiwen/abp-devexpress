using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using DevExpViewer.Authorization.Roles;
using DevExpViewer.Authorization.Users;
using DevExpViewer.MultiTenancy;

namespace DevExpViewer.EntityFrameworkCore
{
    public class DevExpViewerDbContext : AbpZeroDbContext<Tenant, Role, User, DevExpViewerDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public DevExpViewerDbContext(DbContextOptions<DevExpViewerDbContext> options)
            : base(options)
        {
        }
    }
}
