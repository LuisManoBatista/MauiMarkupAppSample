namespace MauiMarkupApp.Resources.Styles;

public static class SubHeadlineStyle
{
    public const string StyleName = "SubHeadline";
    public static Style Create() => new(typeof(Label))
    {
        Setters =
        {
            ApplicationStylesDictionary.AppThemeSetter(Label.TextColorProperty, ApplicationColorsDictionary.MidnightBlue, ApplicationColorsDictionary.White),
            ApplicationStylesDictionary.SimpleSetter(Label.FontSizeProperty, 24),
            ApplicationStylesDictionary.SimpleSetter(View.HorizontalOptionsProperty, LayoutOptions.Center),
            ApplicationStylesDictionary.SimpleSetter(Label.HorizontalTextAlignmentProperty, TextAlignment.Center)
        },
        ApplyToDerivedTypes = false
    };
}