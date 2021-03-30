using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace OrderManagement.EntityFrameworkCore
{
    public class OrderManagementHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<OrderManagementHttpApiHostMigrationsDbContext>
    {
        public OrderManagementHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<OrderManagementHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("OrderManagement"));

            return new OrderManagementHttpApiHostMigrationsDbContext(builder.Options);
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
