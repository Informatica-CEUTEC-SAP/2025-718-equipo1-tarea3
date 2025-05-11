using Volo.Abp.Modularity;

namespace Acme.Bookstore;

[DependsOn(
    typeof(BookstoreDomainModule),
    typeof(BookstoreTestBaseModule)
)]
public class BookstoreDomainTestModule : AbpModule
{

}
