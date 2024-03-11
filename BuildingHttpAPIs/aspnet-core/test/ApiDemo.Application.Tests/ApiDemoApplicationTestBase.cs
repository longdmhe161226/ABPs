using Volo.Abp.Modularity;

namespace ApiDemo;

public abstract class ApiDemoApplicationTestBase<TStartupModule> : ApiDemoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
