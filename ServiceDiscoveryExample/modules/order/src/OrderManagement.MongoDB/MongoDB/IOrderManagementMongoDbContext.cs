using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace OrderManagement.MongoDB
{
    [ConnectionStringName(OrderManagementDbProperties.ConnectionStringName)]
    public interface IOrderManagementMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
