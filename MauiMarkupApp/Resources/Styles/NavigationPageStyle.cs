namespace MauiMarkupApp.Resources.Styles;

public static class NavigationPageStyle
{
    public static Style Create() => new(typeof(NavigationPage))
    {
        Setters =
        {
            ApplicationStylesDictionary.AppThemeSetter(NavigationPage.BarBackgroundColorProperty, ApplicationColorsDictionary.White, ApplicationColorsDictionary.OffBlack),
            ApplicationStylesDictionary.AppThemeSetter(NavigationPage.BarTextColorProperty, ApplicationColorsDictionary.Gray200, ApplicationColorsDictionary.White),
            ApplicationStylesDictionary.AppThemeSetter(NavigationPage.IconColorProperty, ApplicationColorsDictionary.Gray200, ApplicationColorsDictionary.White)
        }
    };
}