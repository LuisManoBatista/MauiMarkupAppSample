using CommunityToolkit.Maui.Markup;
using MauiMarkupApp.Resources.Styles.Extensions;

namespace MauiMarkupApp.Resources.Styles;

public static class SwitchStyle
{
    public static Style Create() =>
        new Style<Switch>()
            .AddAppThemeBinding(Switch.OnColorProperty, ApplicationColorsDictionary.Primary, ApplicationColorsDictionary.White)
            .Add(Switch.ThumbColorProperty, ApplicationColorsDictionary.White)
            .AddVisualStateGroupList(groups =>
                groups.AddItem("CommonStates", group =>
                {
                    group.Add("Normal");
                    group.Add("Disabled", state =>
                    {
                        state.AddAppThemeBinding(Switch.OnColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600);
                        state.AddAppThemeBinding(Switch.ThumbColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600);
                    });
                    group.Add("On", state =>
                    {
                        state.AddAppThemeBinding(Switch.OnColorProperty, ApplicationColorsDictionary.Secondary, ApplicationColorsDictionary.Gray200);
                        state.AddAppThemeBinding(Switch.ThumbColorProperty, ApplicationColorsDictionary.Primary, ApplicationColorsDictionary.White);
                    });
                    group.Add("Off", state =>
                    {
                        state.AddAppThemeBinding(Switch.ThumbColorProperty, ApplicationColorsDictionary.Gray400, ApplicationColorsDictionary.Gray500);
                    });
                }));
}