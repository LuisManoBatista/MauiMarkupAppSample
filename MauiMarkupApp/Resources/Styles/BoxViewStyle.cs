using CommunityToolkit.Maui.Markup;

namespace MauiMarkupApp.Resources.Styles;

public static class BoxViewStyle
{
    public static Style Create() =>
        new Style<BoxView>()
            .AddAppThemeBinding(VisualElement.BackgroundColorProperty, ApplicationColorsDictionary.Gray950, ApplicationColorsDictionary.Gray200);
}