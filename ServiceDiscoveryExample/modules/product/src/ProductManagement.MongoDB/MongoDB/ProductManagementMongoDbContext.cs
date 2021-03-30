using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace ProductManagement.MongoDB
{
    [ConnectionStringName(ProductManagementDbProperties.ConnectionStringName)]
    public class ProductManagementMongoDbContext : AbpMongoDbContext, IProductManagementMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureProductManagement();
        }
    }
}