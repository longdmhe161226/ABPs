using AngularABP.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AngularABP.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AngularABPEntityFrameworkCoreModule),
    typeof(AngularABPApplicationContractsModule)
    )]
public class AngularABPDbMigratorModule : AbpModule
{
}
