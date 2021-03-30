using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace ProductManagement.EntityFrameworkCore
{
    public class ProductManagementHttpApiHostMigrationsDbContext : AbpDbContext<ProductManagementHttpApiHostMigrationsDbContext>
    {
        public ProductManagementHttpApiHostMigrationsDbContext(DbContextOptions<ProductManagementHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureProductManagement();
        }
    }
}
