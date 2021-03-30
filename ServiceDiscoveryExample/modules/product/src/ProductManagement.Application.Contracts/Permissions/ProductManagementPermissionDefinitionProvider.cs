using ProductManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ProductManagement.Permissions
{
    public class ProductManagementPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ProductManagementPermissions.GroupName, L("Permission:ProductManagement"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ProductManagementResource>(name);
        }
    }
}