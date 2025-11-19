using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AbpBlazorSolution.Data;

public class AbpBlazorSolutionDbContextFactory : IDesignTimeDbContextFactory<AbpBlazorSolutionDbContext>
{
    public AbpBlazorSolutionDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<AbpBlazorSolutionDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new AbpBlazorSolutionDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}