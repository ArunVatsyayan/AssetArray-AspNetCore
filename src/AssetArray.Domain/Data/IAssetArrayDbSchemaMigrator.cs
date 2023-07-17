using System.Threading.Tasks;

namespace AssetArray.Data;

public interface IAssetArrayDbSchemaMigrator
{
    Task MigrateAsync();
}
