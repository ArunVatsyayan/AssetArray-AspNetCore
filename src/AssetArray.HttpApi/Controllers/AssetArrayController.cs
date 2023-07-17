using AssetArray.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AssetArray.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AssetArrayController : AbpControllerBase
{
    protected AssetArrayController()
    {
        LocalizationResource = typeof(AssetArrayResource);
    }
}
