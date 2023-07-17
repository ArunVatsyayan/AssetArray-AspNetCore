using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AssetArray.Data;

/* This is used if database provider does't define
 * IAssetArrayDbSchemaMigrator implementation.
 */
public class NullAssetArrayDbSchemaMigrator : IAssetArrayDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
