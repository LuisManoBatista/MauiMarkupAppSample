namespace MauiMarkupApp.Resources.Styles;

public static class ListViewStyle
{
    public static Style Create() => new(typeof(ListView))
    {
        Setters =
        {
            ApplicationStylesDictionary.AppThemeSetter(ListView.SeparatorColorProperty, ApplicationColorsDictionary.Gray200, ApplicationColorsDictionary.Gray500),
            ApplicationStylesDictionary.AppThemeSetter(ListView.RefreshControlColorProperty, ApplicationColorsDictionary.Gray900, ApplicationColorsDictionary.Gray200)
        }
    };
}