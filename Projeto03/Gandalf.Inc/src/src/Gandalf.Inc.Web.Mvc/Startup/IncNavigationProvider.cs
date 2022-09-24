using Abp.Application.Navigation;
using Abp.Authorization;
using Abp.Localization;
using Gandalf.Inc.Authorization;

namespace Gandalf.Inc.Web.Startup
{
    /// <summary>
    /// This class defines menus for the application.
    /// </summary>
    public class IncNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
               .AddItem(
                    new MenuItemDefinition(
                        PageNames.Home,
                        L("HomePage"),
                        url: "",
                        icon: "fas fa-home",
                        requiresAuthentication: true
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Customers,
                        L("Customers"),
                        url: "",
                        icon: "fas fa-university",
                        requiresAuthentication: true
                    )
                ).
                AddItem(
                    new MenuItemDefinition(
                        PageNames.Products,
                        L("Products"),
                        url: "",
                        icon: "fas fa-university",
                        requiresAuthentication: true
                    )
                ).
                AddItem(
                    new MenuItemDefinition(
                        PageNames.Orders,
                        L("Orders"),
                        url: "",
                        icon: "fas fa-university",
                        requiresAuthentication: true
                    )
                ).
                AddItem(
                    new MenuItemDefinition(
                        PageNames.Families,
                        L("Families"),
                        url: "",
                        icon: "fas fa-university",
                        requiresAuthentication: true
                    )
                ).
                AddItem(
                    new MenuItemDefinition(
                        PageNames.Stocks,
                        L("Stocks"),
                        url: "",
                        icon: "fas fa-university",
                        requiresAuthentication: true
                    )
                ).
                AddItem(
                    new MenuItemDefinition(
                        PageNames.Stores,
                        L("Stores"),
                        url: "",
                        icon: "fas fa-university",
                        requiresAuthentication: true
                    )
                ).
                AddItem(
                    new MenuItemDefinition(
                        PageNames.Users,
                        L("Users"),
                        url: "Users",
                        icon: "fas fa-users",
                        permissionDependency: new SimplePermissionDependency(PermissionNames.Pages_Users)
                    )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, IncConsts.LocalizationSourceName);
        }
    }
}