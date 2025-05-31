namespace MauiMarkupApp.Resources.Styles;

public static class SpanStyle
{
    public static Style Create() => new(typeof(Span))
    {
        Setters =
        {
            ApplicationStylesDictionary.AppThemeSetter(Span.TextColorProperty, ApplicationColorsDictionary.Black, ApplicationColorsDictionary.White)
        }
    };
}