using AssetArray.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AssetArray.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AssetArrayEntityFrameworkCoreModule),
    typeof(AssetArrayApplicationContractsModule)
    )]
public class AssetArrayDbMigratorModule : AbpModule
{
}
