using Volo.Abp.Modularity;

namespace AngularABP;

public abstract class AngularABPApplicationTestBase<TStartupModule> : AngularABPTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
