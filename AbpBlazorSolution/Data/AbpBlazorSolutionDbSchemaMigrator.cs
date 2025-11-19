using Volo.Abp.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace AbpBlazorSolution.Data;

public class AbpBlazorSolutionDbSchemaMigrator : ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public AbpBlazorSolutionDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        
        /* We intentionally resolving the AbpBlazorSolutionDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AbpBlazorSolutionDbContext>()
            .Database
            .MigrateAsync();

    }
}
