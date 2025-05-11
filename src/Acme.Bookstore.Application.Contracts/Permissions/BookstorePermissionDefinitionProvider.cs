using Acme.Bookstore.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Acme.Bookstore.Permissions;

public class BookstorePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BookstorePermissions.GroupName);

        var booksPermission = myGroup.AddPermission(BookstorePermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(BookstorePermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(BookstorePermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(BookstorePermissions.Books.Delete, L("Permission:Books.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(BookstorePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BookstoreResource>(name);
    }
}
