using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ProductManagement.EntityFrameworkCore
{
    public class ProductManagementHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<ProductManagementHttpApiHostMigrationsDbContext>
    {
        public ProductManagementHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<ProductManagementHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("ProductManagement"));

            return new ProductManagementHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
