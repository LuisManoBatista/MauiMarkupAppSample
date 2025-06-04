using CommunityToolkit.Maui.Markup;

namespace MauiMarkupApp.Resources.Styles;

public static class RefreshViewStyle
{
    public static Style Create() =>
        new Style<RefreshView>()
            .AddAppThemeBinding(RefreshView.RefreshColorProperty, ApplicationColorsDictionary.Gray900, ApplicationColorsDictionary.Gray200);
}