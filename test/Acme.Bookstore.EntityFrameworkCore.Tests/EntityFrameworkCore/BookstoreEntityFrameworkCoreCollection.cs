using Xunit;

namespace Acme.Bookstore.EntityFrameworkCore;

[CollectionDefinition(BookstoreTestConsts.CollectionDefinitionName)]
public class BookstoreEntityFrameworkCoreCollection : ICollectionFixture<BookstoreEntityFrameworkCoreFixture>
{

}
