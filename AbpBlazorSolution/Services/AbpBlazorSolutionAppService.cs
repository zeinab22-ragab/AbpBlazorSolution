using Volo.Abp.Application.Services;
using AbpBlazorSolution.Localization;

namespace AbpBlazorSolution.Services;

/* Inherit your application services from this class. */
public abstract class AbpBlazorSolutionAppService : ApplicationService
{
    protected AbpBlazorSolutionAppService()
    {
        LocalizationResource = typeof(AbpBlazorSolutionResource);
    }
}