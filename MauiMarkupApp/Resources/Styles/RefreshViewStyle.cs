namespace MauiMarkupApp.Resources.Styles;

public static class RefreshViewStyle
{
    public static Style Create() => new(typeof(RefreshView))
    {
        Setters = { ApplicationStylesDictionary.AppThemeBinding(RefreshView.RefreshColorProperty, ApplicationColorsDictionary.Gray900, ApplicationColorsDictionary.Gray200) }
    };
}