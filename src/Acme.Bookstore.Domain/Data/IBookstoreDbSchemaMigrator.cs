using System.Threading.Tasks;

namespace Acme.Bookstore.Data;

public interface IBookstoreDbSchemaMigrator
{
    Task MigrateAsync();
}
