using CommunityToolkit.Maui.Markup;

namespace MauiMarkupApp.Resources.Styles;

public static class NavigationPageStyle
{
    public static Style Create() =>
        new Style<NavigationPage>()
            .AddAppThemeBinding(NavigationPage.BarBackgroundColorProperty, ApplicationColorsDictionary.White, ApplicationColorsDictionary.OffBlack)
            .AddAppThemeBinding(NavigationPage.BarTextColorProperty, ApplicationColorsDictionary.Gray200, ApplicationColorsDictionary.White)
            .AddAppThemeBinding(NavigationPage.IconColorProperty, ApplicationColorsDictionary.Gray200, ApplicationColorsDictionary.White);
}