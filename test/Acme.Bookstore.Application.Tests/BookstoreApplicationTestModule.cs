using Volo.Abp.Modularity;

namespace Acme.Bookstore;

[DependsOn(
    typeof(BookstoreApplicationModule),
    typeof(BookstoreDomainTestModule)
)]
public class BookstoreApplicationTestModule : AbpModule
{

}
