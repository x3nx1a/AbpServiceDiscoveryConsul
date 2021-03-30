using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace OrderManagement.EntityFrameworkCore
{
    public class OrderManagementHttpApiHostMigrationsDbContext : AbpDbContext<OrderManagementHttpApiHostMigrationsDbContext>
    {
        public OrderManagementHttpApiHostMigrationsDbContext(DbContextOptions<OrderManagementHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureOrderManagement();
        }
    }
}
