using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace ProductManagement.MongoDB
{
    [ConnectionStringName(ProductManagementDbProperties.ConnectionStringName)]
    public interface IProductManagementMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
