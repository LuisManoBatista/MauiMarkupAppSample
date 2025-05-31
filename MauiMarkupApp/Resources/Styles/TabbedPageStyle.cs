namespace MauiMarkupApp.Resources.Styles;

public static class TabbedPageStyle
{
    public static Style Create() => new(typeof(TabbedPage))
    {
        Setters =
        {
            ApplicationStylesDictionary.AppThemeSetter(TabbedPage.BarBackgroundColorProperty, ApplicationColorsDictionary.White, ApplicationColorsDictionary.Gray950),
            ApplicationStylesDictionary.AppThemeSetter(TabbedPage.BarTextColorProperty, ApplicationColorsDictionary.Magenta, ApplicationColorsDictionary.White),
            ApplicationStylesDictionary.AppThemeSetter(TabbedPage.UnselectedTabColorProperty, ApplicationColorsDictionary.Gray200, ApplicationColorsDictionary.Gray950),
            ApplicationStylesDictionary.AppThemeSetter(TabbedPage.SelectedTabColorProperty, ApplicationColorsDictionary.Gray950, ApplicationColorsDictionary.Gray200)
        }
    };
}
