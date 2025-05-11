using Acme.Bookstore.Samples;
using Xunit;

namespace Acme.Bookstore.EntityFrameworkCore.Applications;

[Collection(BookstoreTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<BookstoreEntityFrameworkCoreTestModule>
{

}
