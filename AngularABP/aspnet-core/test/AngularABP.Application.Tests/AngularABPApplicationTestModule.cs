using Volo.Abp.Modularity;

namespace AngularABP;

[DependsOn(
    typeof(AngularABPApplicationModule),
    typeof(AngularABPDomainTestModule)
)]
public class AngularABPApplicationTestModule : AbpModule
{

}
