using System;
using System.Collections.Generic;
using System.Text;
using AssetArray.Localization;
using Volo.Abp.Application.Services;

namespace AssetArray;

/* Inherit your application services from this class.
 */
public abstract class AssetArrayAppService : ApplicationService
{
    protected AssetArrayAppService()
    {
        LocalizationResource = typeof(AssetArrayResource);
    }
}
