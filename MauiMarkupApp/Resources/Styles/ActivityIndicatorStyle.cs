namespace MauiMarkupApp.Resources.Styles;

public static class ActivityIndicatorStyle
{
    public static Style Create() => new(typeof(ActivityIndicator))
    {
        Setters = { ApplicationStylesDictionary.AppThemeSetter(ActivityIndicator.ColorProperty, ApplicationColorsDictionary.Primary, ApplicationColorsDictionary.White) }
    };
}