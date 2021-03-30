using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace OrderManagement.MongoDB
{
    public class OrderManagementMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public OrderManagementMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}