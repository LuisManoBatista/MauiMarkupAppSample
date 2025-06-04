using CommunityToolkit.Maui.Markup;

namespace MauiMarkupApp.Resources.Styles;

public static class SwipeItemStyle
{
    public static Style Create() =>
        new Style<SwipeItem>()
            .AddAppThemeBinding(VisualElement.BackgroundColorProperty, ApplicationColorsDictionary.White, ApplicationColorsDictionary.Black);
}