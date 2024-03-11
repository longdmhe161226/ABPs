using System;
using System.Collections.Generic;
using System.Text;
using AngularABP.Localization;
using Volo.Abp.Application.Services;

namespace AngularABP;

/* Inherit your application services from this class.
 */
public abstract class AngularABPAppService : ApplicationService
{
    protected AngularABPAppService()
    {
        LocalizationResource = typeof(AngularABPResource);
    }
}
