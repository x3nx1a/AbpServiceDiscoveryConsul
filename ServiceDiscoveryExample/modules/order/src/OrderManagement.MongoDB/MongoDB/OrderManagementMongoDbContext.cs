using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace OrderManagement.MongoDB
{
    [ConnectionStringName(OrderManagementDbProperties.ConnectionStringName)]
    public class OrderManagementMongoDbContext : AbpMongoDbContext, IOrderManagementMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureOrderManagement();
        }
    }
}