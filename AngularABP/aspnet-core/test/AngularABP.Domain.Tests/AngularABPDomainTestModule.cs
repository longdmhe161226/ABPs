using Volo.Abp.Modularity;

namespace AngularABP;

[DependsOn(
    typeof(AngularABPDomainModule),
    typeof(AngularABPTestBaseModule)
)]
public class AngularABPDomainTestModule : AbpModule
{

}
