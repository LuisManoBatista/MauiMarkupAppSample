using CommunityToolkit.Maui.Markup;

namespace MauiMarkupApp.Resources.Styles;

public static class IndicatorViewStyle
{
    public static Style Create() =>
        new Style<IndicatorView>()
            .AddAppThemeBinding(IndicatorView.IndicatorColorProperty, ApplicationColorsDictionary.Gray200, ApplicationColorsDictionary.Gray500)
            .AddAppThemeBinding(IndicatorView.SelectedIndicatorColorProperty, ApplicationColorsDictionary.Gray950, ApplicationColorsDictionary.Gray100);
}