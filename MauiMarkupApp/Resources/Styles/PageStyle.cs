using CommunityToolkit.Maui.Markup;

namespace MauiMarkupApp.Resources.Styles;

public static class PageStyle
{
    public static Style Create() =>
        new Style<Page>()
            .AddAppThemeBinding(VisualElement.BackgroundColorProperty, ApplicationColorsDictionary.White, ApplicationColorsDictionary.OffBlack)
            .Add(Page.PaddingProperty, 0);
}