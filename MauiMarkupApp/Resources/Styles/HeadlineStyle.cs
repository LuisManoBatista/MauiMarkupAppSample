using CommunityToolkit.Maui.Markup;

namespace MauiMarkupApp.Resources.Styles;

public static class HeadlineStyle
{
    public const string StyleName = "Headline";
    public static Style Create() =>
        new Style<Label>()
            .AddAppThemeBinding(Label.TextColorProperty, ApplicationColorsDictionary.MidnightBlue, ApplicationColorsDictionary.White)
            .Add(Label.FontSizeProperty, 32)
            .Add(View.HorizontalOptionsProperty, LayoutOptions.Center)
            .Add(Label.HorizontalTextAlignmentProperty, TextAlignment.Center);
}