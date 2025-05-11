using Volo.Abp.Modularity;

namespace Acme.Bookstore;

public abstract class BookstoreApplicationTestBase<TStartupModule> : BookstoreTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
