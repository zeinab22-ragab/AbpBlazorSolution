using Microsoft.Extensions.Localization;
using AbpBlazorSolution.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpBlazorSolution;

[Dependency(ReplaceServices = true)]
public class AbpBlazorSolutionBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<AbpBlazorSolutionResource> _localizer;

    public AbpBlazorSolutionBrandingProvider(IStringLocalizer<AbpBlazorSolutionResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
