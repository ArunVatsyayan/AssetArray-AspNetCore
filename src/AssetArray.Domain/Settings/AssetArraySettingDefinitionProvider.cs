using Volo.Abp.Settings;

namespace AssetArray.Settings;

public class AssetArraySettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AssetArraySettings.MySetting1));
    }
}
