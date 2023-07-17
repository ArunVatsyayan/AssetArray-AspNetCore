using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AssetArray.Data;
using Volo.Abp.DependencyInjection;

namespace AssetArray.EntityFrameworkCore;

public class EntityFrameworkCoreAssetArrayDbSchemaMigrator
    : IAssetArrayDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAssetArrayDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AssetArrayDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AssetArrayDbContext>()
            .Database
            .MigrateAsync();
    }
}
