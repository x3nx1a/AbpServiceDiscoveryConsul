using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace ProductManagement.EntityFrameworkCore
{
    [ConnectionStringName(ProductManagementDbProperties.ConnectionStringName)]
    public interface IProductManagementDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}