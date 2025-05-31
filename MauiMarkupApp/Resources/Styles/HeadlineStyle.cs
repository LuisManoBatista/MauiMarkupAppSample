namespace MauiMarkupApp.Resources.Styles;

public static class HeadlineStyle
{
    public const string StyleName = "Headline";
    public static Style Create() => new(typeof(Label))
    {
        Setters =
        {
            ApplicationStylesDictionary.AppThemeSetter(Label.TextColorProperty, ApplicationColorsDictionary.MidnightBlue, ApplicationColorsDictionary.White),
            ApplicationStylesDictionary.SimpleSetter(Label.FontSizeProperty, 32),
            ApplicationStylesDictionary.SimpleSetter(Label.HorizontalOptionsProperty, LayoutOptions.Center),
            ApplicationStylesDictionary.SimpleSetter(Label.HorizontalTextAlignmentProperty, TextAlignment.Center)
        },
        ApplyToDerivedTypes = false
    };
}