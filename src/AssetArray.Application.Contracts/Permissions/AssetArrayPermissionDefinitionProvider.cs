using AssetArray.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AssetArray.Permissions;

public class AssetArrayPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AssetArrayPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AssetArrayPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AssetArrayResource>(name);
    }
}
