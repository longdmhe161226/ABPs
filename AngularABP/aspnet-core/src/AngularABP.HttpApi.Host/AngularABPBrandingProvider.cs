using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AngularABP;

[Dependency(ReplaceServices = true)]
public class AngularABPBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AngularABP";
}
