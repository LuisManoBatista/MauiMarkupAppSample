using CommunityToolkit.Maui.Markup;

namespace MauiMarkupApp.Resources.Styles;

public static class SpanStyle
{
    public static Style Create() =>
        new Style<Span>()
            .AddAppThemeBinding(Span.TextColorProperty, ApplicationColorsDictionary.Black, ApplicationColorsDictionary.White);
}