using Volo.Abp.Modularity;

namespace ApiDemo;

[DependsOn(
    typeof(ApiDemoDomainModule),
    typeof(ApiDemoTestBaseModule)
)]
public class ApiDemoDomainTestModule : AbpModule
{

}
