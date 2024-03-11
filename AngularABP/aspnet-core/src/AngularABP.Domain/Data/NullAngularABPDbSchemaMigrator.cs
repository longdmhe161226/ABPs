using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AngularABP.Data;

/* This is used if database provider does't define
 * IAngularABPDbSchemaMigrator implementation.
 */
public class NullAngularABPDbSchemaMigrator : IAngularABPDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
