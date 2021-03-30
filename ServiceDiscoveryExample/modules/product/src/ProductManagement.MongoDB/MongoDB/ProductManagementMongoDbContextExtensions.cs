using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace ProductManagement.MongoDB
{
    public static class ProductManagementMongoDbContextExtensions
    {
        public static void ConfigureProductManagement(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new ProductManagementMongoModelBuilderConfigurationOptions(
                ProductManagementDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}