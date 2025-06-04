using CommunityToolkit.Maui.Markup;
using MauiMarkupApp.Resources.Styles.Extensions;

namespace MauiMarkupApp.Resources.Styles;

public static class ProgressBarStyle
{
    public static Style Create() =>
        new Style<ProgressBar>()
            .AddAppThemeBinding(ProgressBar.ProgressColorProperty, ApplicationColorsDictionary.Primary, ApplicationColorsDictionary.White)
            .AddVisualStateGroupList(groups =>
                groups.AddItem("CommonStates", group =>
                {
                    group.Add("Normal");
                    group.Add("Disabled", state =>
                        state.AddAppThemeBinding(ProgressBar.ProgressColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600));
                }));
}