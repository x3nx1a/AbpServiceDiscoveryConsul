using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace ProductManagement.MongoDB
{
    public class ProductManagementMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public ProductManagementMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}