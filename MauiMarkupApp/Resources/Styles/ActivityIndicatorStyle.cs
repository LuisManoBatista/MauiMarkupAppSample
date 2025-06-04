using CommunityToolkit.Maui.Markup;

namespace MauiMarkupApp.Resources.Styles;

public static class ActivityIndicatorStyle
{
    public static Style Create() =>
        new Style<ActivityIndicator>()
            .AddAppThemeBinding(ActivityIndicator.ColorProperty, ApplicationColorsDictionary.Primary, ApplicationColorsDictionary.White);
}