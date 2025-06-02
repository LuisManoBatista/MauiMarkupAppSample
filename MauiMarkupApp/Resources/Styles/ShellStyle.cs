namespace MauiMarkupApp.Resources.Styles;

public static class ShellStyle
{
    public static Style Create() => new(typeof(Shell))
    {
        Setters =
        {
            ApplicationStylesDictionary.AppThemeBinding(Shell.BackgroundColorProperty, ApplicationColorsDictionary.White, ApplicationColorsDictionary.OffBlack),
            ApplicationStylesDictionary.AppThemeBinding(Shell.ForegroundColorProperty, ApplicationColorsDictionary.Black, ApplicationColorsDictionary.SecondaryDarkText),
            ApplicationStylesDictionary.AppThemeBinding(Shell.TitleColorProperty, ApplicationColorsDictionary.Black, ApplicationColorsDictionary.SecondaryDarkText),
            ApplicationStylesDictionary.AppThemeBinding(Shell.DisabledColorProperty, ApplicationColorsDictionary.Gray200, ApplicationColorsDictionary.Gray950),
            ApplicationStylesDictionary.AppThemeBinding(Shell.UnselectedColorProperty, ApplicationColorsDictionary.Gray200, ApplicationColorsDictionary.Gray200),
            ApplicationStylesDictionary.SimpleSetter(Shell.NavBarHasShadowProperty, false),
            ApplicationStylesDictionary.AppThemeBinding(Shell.TabBarBackgroundColorProperty, ApplicationColorsDictionary.White, ApplicationColorsDictionary.Black),
            ApplicationStylesDictionary.AppThemeBinding(Shell.TabBarForegroundColorProperty, ApplicationColorsDictionary.Magenta, ApplicationColorsDictionary.White),
            ApplicationStylesDictionary.AppThemeBinding(Shell.TabBarTitleColorProperty, ApplicationColorsDictionary.Magenta, ApplicationColorsDictionary.White),
            ApplicationStylesDictionary.AppThemeBinding(Shell.TabBarUnselectedColorProperty, ApplicationColorsDictionary.Gray900, ApplicationColorsDictionary.Gray200)
        },
        ApplyToDerivedTypes = true
    };
}