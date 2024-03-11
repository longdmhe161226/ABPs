using Volo.Abp.Modularity;

namespace AngularABP;

/* Inherit from this class for your domain layer tests. */
public abstract class AngularABPDomainTestBase<TStartupModule> : AngularABPTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
