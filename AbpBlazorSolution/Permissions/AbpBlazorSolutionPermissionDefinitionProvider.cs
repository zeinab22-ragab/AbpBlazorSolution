using AbpBlazorSolution.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpBlazorSolution.Permissions;

public class AbpBlazorSolutionPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AbpBlazorSolutionPermissions.GroupName);


        //Define your own permissions here. Example:
        //myGroup.AddPermission(AbpBlazorSolutionPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpBlazorSolutionResource>(name);
    }
}
