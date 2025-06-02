namespace MauiMarkupApp.Resources.Styles;

public static class TabbedPageStyle
{
    public static Style Create() => new(typeof(TabbedPage))
    {
        Setters =
        {
            ApplicationStylesDictionary.AppThemeBinding(TabbedPage.BarBackgroundColorProperty, ApplicationColorsDictionary.White, ApplicationColorsDictionary.Gray950),
            ApplicationStylesDictionary.AppThemeBinding(TabbedPage.BarTextColorProperty, ApplicationColorsDictionary.Magenta, ApplicationColorsDictionary.White),
            ApplicationStylesDictionary.AppThemeBinding(TabbedPage.UnselectedTabColorProperty, ApplicationColorsDictionary.Gray200, ApplicationColorsDictionary.Gray950),
            ApplicationStylesDictionary.AppThemeBinding(TabbedPage.SelectedTabColorProperty, ApplicationColorsDictionary.Gray950, ApplicationColorsDictionary.Gray200)
        }
    };
}
