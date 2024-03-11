using ApiDemo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ApiDemo.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ApiDemoEntityFrameworkCoreModule),
    typeof(ApiDemoApplicationContractsModule)
    )]
public class ApiDemoDbMigratorModule : AbpModule
{
}
