using Volo.Abp.Modularity;

namespace ApiDemo;

/* Inherit from this class for your domain layer tests. */
public abstract class ApiDemoDomainTestBase<TStartupModule> : ApiDemoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
