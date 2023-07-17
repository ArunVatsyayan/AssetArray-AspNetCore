using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AssetArray;

[Dependency(ReplaceServices = true)]
public class AssetArrayBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AssetArray";
}
