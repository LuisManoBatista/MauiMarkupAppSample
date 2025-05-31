namespace MauiMarkupApp.Resources.Styles;

public static class ShellStyle
{
    public static Style Create() => new(typeof(Shell))
    {
        Setters =
        {
            ApplicationStylesDictionary.AppThemeSetter(Shell.BackgroundColorProperty, ApplicationColorsDictionary.White, ApplicationColorsDictionary.OffBlack),
            ApplicationStylesDictionary.AppThemeSetter(Shell.ForegroundColorProperty, ApplicationColorsDictionary.Black, ApplicationColorsDictionary.SecondaryDarkText),
            ApplicationStylesDictionary.AppThemeSetter(Shell.TitleColorProperty, ApplicationColorsDictionary.Black, ApplicationColorsDictionary.SecondaryDarkText),
            ApplicationStylesDictionary.AppThemeSetter(Shell.DisabledColorProperty, ApplicationColorsDictionary.Gray200, ApplicationColorsDictionary.Gray950),
            ApplicationStylesDictionary.AppThemeSetter(Shell.UnselectedColorProperty, ApplicationColorsDictionary.Gray200, ApplicationColorsDictionary.Gray200),
            ApplicationStylesDictionary.SimpleSetter(Shell.NavBarHasShadowProperty, false),
            ApplicationStylesDictionary.AppThemeSetter(Shell.TabBarBackgroundColorProperty, ApplicationColorsDictionary.White, ApplicationColorsDictionary.Black),
            ApplicationStylesDictionary.AppThemeSetter(Shell.TabBarForegroundColorProperty, ApplicationColorsDictionary.Magenta, ApplicationColorsDictionary.White),
            ApplicationStylesDictionary.AppThemeSetter(Shell.TabBarTitleColorProperty, ApplicationColorsDictionary.Magenta, ApplicationColorsDictionary.White),
            ApplicationStylesDictionary.AppThemeSetter(Shell.TabBarUnselectedColorProperty, ApplicationColorsDictionary.Gray900, ApplicationColorsDictionary.Gray200)
        },
        ApplyToDerivedTypes = true
    };
}