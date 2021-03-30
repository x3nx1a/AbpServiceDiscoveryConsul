using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace ProductManagement.EntityFrameworkCore
{
    public class ProductManagementModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public ProductManagementModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}