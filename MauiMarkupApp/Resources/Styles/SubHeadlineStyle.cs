using CommunityToolkit.Maui.Markup;

namespace MauiMarkupApp.Resources.Styles;

public static class SubHeadlineStyle
{
    public const string StyleName = "SubHeadline";
    public static Style Create() =>
        new Style<Label>()
            .AddAppThemeBinding(Label.TextColorProperty, ApplicationColorsDictionary.MidnightBlue, ApplicationColorsDictionary.White)
            .Add(Label.FontSizeProperty, 24)
            .Add(View.HorizontalOptionsProperty, LayoutOptions.Center)
            .Add(Label.HorizontalTextAlignmentProperty, TextAlignment.Center);
}