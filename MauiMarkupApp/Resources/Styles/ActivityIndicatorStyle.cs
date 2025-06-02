namespace MauiMarkupApp.Resources.Styles;

public static class ActivityIndicatorStyle
{
    public static Style Create() => new(typeof(ActivityIndicator))
    {
        Setters = { ApplicationStylesDictionary.AppThemeBinding(ActivityIndicator.ColorProperty, ApplicationColorsDictionary.Primary, ApplicationColorsDictionary.White) }
    };
}