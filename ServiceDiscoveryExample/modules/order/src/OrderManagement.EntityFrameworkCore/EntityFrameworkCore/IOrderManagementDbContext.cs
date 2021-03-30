using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace OrderManagement.EntityFrameworkCore
{
    [ConnectionStringName(OrderManagementDbProperties.ConnectionStringName)]
    public interface IOrderManagementDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}