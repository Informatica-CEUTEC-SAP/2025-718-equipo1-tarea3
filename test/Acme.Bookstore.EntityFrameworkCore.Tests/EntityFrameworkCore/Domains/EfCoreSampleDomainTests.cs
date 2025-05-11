using Acme.Bookstore.Samples;
using Xunit;

namespace Acme.Bookstore.EntityFrameworkCore.Domains;

[Collection(BookstoreTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<BookstoreEntityFrameworkCoreTestModule>
{

}
