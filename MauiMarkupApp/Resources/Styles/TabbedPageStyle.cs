using CommunityToolkit.Maui.Markup;

namespace MauiMarkupApp.Resources.Styles;

public static class TabbedPageStyle
{
    public static Style Create() =>
        new Style<TabbedPage>()
            .AddAppThemeBinding(TabbedPage.BarBackgroundColorProperty, ApplicationColorsDictionary.White, ApplicationColorsDictionary.Gray950)
            .AddAppThemeBinding(TabbedPage.BarTextColorProperty, ApplicationColorsDictionary.Magenta, ApplicationColorsDictionary.White)
            .AddAppThemeBinding(TabbedPage.UnselectedTabColorProperty, ApplicationColorsDictionary.Gray200, ApplicationColorsDictionary.Gray950)
            .AddAppThemeBinding(TabbedPage.SelectedTabColorProperty, ApplicationColorsDictionary.Gray950, ApplicationColorsDictionary.Gray200);
}
