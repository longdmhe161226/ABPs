using AngularABP.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AngularABP.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AngularABPController : AbpControllerBase
{
    protected AngularABPController()
    {
        LocalizationResource = typeof(AngularABPResource);
    }
}
