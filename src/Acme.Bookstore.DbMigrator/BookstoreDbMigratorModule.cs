using Acme.Bookstore.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.Bookstore.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BookstoreEntityFrameworkCoreModule),
    typeof(BookstoreApplicationContractsModule)
)]
public class BookstoreDbMigratorModule : AbpModule
{
}
