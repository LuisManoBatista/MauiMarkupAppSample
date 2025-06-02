namespace MauiMarkupApp.Resources.Styles;

public static class IndicatorViewStyle
{
    public static Style Create() => new(typeof(IndicatorView))
    {
        Setters =
        {
            ApplicationStylesDictionary.AppThemeBinding(IndicatorView.IndicatorColorProperty, ApplicationColorsDictionary.Gray200, ApplicationColorsDictionary.Gray500),
            ApplicationStylesDictionary.AppThemeBinding(IndicatorView.SelectedIndicatorColorProperty, ApplicationColorsDictionary.Gray950, ApplicationColorsDictionary.Gray100)
        }
    };
}