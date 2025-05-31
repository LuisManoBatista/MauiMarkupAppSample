namespace MauiMarkupApp.Resources.Styles;

public static class IndicatorViewStyle
{
    public static Style Create() => new(typeof(IndicatorView))
    {
        Setters =
        {
            ApplicationStylesDictionary.AppThemeSetter(IndicatorView.IndicatorColorProperty, ApplicationColorsDictionary.Gray200, ApplicationColorsDictionary.Gray500),
            ApplicationStylesDictionary.AppThemeSetter(IndicatorView.SelectedIndicatorColorProperty, ApplicationColorsDictionary.Gray950, ApplicationColorsDictionary.Gray100)
        }
    };
}