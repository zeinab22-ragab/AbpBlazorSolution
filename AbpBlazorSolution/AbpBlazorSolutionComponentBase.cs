using AbpBlazorSolution.Localization;
using Volo.Abp.AspNetCore.Components;

namespace AbpBlazorSolution;

public abstract class AbpBlazorSolutionComponentBase : AbpComponentBase
{
    protected AbpBlazorSolutionComponentBase()
    {
        LocalizationResource = typeof(AbpBlazorSolutionResource);
    }
}
