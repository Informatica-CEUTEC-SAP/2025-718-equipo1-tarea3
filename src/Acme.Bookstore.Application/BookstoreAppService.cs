using Acme.Bookstore.Localization;
using Volo.Abp.Application.Services;

namespace Acme.Bookstore;

/* Inherit your application services from this class.
 */
public abstract class BookstoreAppService : ApplicationService
{
    protected BookstoreAppService()
    {
        LocalizationResource = typeof(BookstoreResource);
    }
}
