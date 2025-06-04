using CommunityToolkit.Maui.Markup;

namespace MauiMarkupApp.Resources.Styles;

public static class ListViewStyle
{
    public static Style Create() =>
        new Style<ListView>()
            .AddAppThemeBinding(ListView.SeparatorColorProperty, ApplicationColorsDictionary.Gray200, ApplicationColorsDictionary.Gray500)
            .AddAppThemeBinding(ListView.RefreshControlColorProperty, ApplicationColorsDictionary.Gray900, ApplicationColorsDictionary.Gray200);
}