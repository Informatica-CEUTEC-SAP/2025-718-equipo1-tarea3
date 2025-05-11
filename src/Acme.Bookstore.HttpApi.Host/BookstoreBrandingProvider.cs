using Microsoft.Extensions.Localization;
using Acme.Bookstore.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Acme.Bookstore;

[Dependency(ReplaceServices = true)]
public class BookstoreBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<BookstoreResource> _localizer;

    public BookstoreBrandingProvider(IStringLocalizer<BookstoreResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
