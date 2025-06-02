namespace MauiMarkupApp.Resources.Styles;

public static class NavigationPageStyle
{
    public static Style Create() => new(typeof(NavigationPage))
    {
        Setters =
        {
            ApplicationStylesDictionary.AppThemeBinding(NavigationPage.BarBackgroundColorProperty, ApplicationColorsDictionary.White, ApplicationColorsDictionary.OffBlack),
            ApplicationStylesDictionary.AppThemeBinding(NavigationPage.BarTextColorProperty, ApplicationColorsDictionary.Gray200, ApplicationColorsDictionary.White),
            ApplicationStylesDictionary.AppThemeBinding(NavigationPage.IconColorProperty, ApplicationColorsDictionary.Gray200, ApplicationColorsDictionary.White)
        }
    };
}