using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace OrderManagement.MongoDB
{
    public static class OrderManagementMongoDbContextExtensions
    {
        public static void ConfigureOrderManagement(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new OrderManagementMongoModelBuilderConfigurationOptions(
                OrderManagementDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}