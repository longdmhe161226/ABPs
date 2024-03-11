using System.Threading.Tasks;

namespace AngularABP.Data;

public interface IAngularABPDbSchemaMigrator
{
    Task MigrateAsync();
}
