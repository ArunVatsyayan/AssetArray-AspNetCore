using AssetArray.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AssetArray;

[DependsOn(
    typeof(AssetArrayEntityFrameworkCoreTestModule)
    )]
public class AssetArrayDomainTestModule : AbpModule
{

}
