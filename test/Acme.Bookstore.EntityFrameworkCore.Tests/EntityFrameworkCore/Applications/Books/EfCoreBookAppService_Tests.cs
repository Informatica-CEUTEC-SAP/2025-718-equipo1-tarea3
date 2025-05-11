using Acme.Bookstore.Books;
using Xunit;

namespace Acme.Bookstore.EntityFrameworkCore.Applications.Books;

[Collection(BookstoreTestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<BookstoreEntityFrameworkCoreTestModule>
{

}