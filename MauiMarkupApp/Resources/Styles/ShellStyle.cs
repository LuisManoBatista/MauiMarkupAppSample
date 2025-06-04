using CommunityToolkit.Maui.Markup;

namespace MauiMarkupApp.Resources.Styles;

public static class ShellStyle
{
    public static Style Create() =>
        new Style<Shell>()
            .AddAppThemeBinding(Shell.BackgroundColorProperty, ApplicationColorsDictionary.White, ApplicationColorsDictionary.OffBlack)
            .AddAppThemeBinding(Shell.ForegroundColorProperty, ApplicationColorsDictionary.Black, ApplicationColorsDictionary.SecondaryDarkText)
            .AddAppThemeBinding(Shell.TitleColorProperty, ApplicationColorsDictionary.Black, ApplicationColorsDictionary.SecondaryDarkText)
            .AddAppThemeBinding(Shell.DisabledColorProperty, ApplicationColorsDictionary.Gray200, ApplicationColorsDictionary.Gray950)
            .AddAppThemeBinding(Shell.UnselectedColorProperty, ApplicationColorsDictionary.Gray200, ApplicationColorsDictionary.Gray200)
            .Add(Shell.NavBarHasShadowProperty, false)
            .AddAppThemeBinding(Shell.TabBarBackgroundColorProperty, ApplicationColorsDictionary.White, ApplicationColorsDictionary.Black)
            .AddAppThemeBinding(Shell.TabBarForegroundColorProperty, ApplicationColorsDictionary.Magenta, ApplicationColorsDictionary.White)
            .AddAppThemeBinding(Shell.TabBarTitleColorProperty, ApplicationColorsDictionary.Magenta, ApplicationColorsDictionary.White)
            .AddAppThemeBinding(Shell.TabBarUnselectedColorProperty, ApplicationColorsDictionary.Gray900, ApplicationColorsDictionary.Gray200);
}