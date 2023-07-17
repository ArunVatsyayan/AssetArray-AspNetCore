using Volo.Abp.Modularity;

namespace AssetArray;

[DependsOn(
    typeof(AssetArrayApplicationModule),
    typeof(AssetArrayDomainTestModule)
    )]
public class AssetArrayApplicationTestModule : AbpModule
{

}
