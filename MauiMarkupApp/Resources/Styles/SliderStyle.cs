using CommunityToolkit.Maui.Markup;
using MauiMarkupApp.Resources.Styles.Extensions;

namespace MauiMarkupApp.Resources.Styles;

public static class SliderStyle
{
    public static Style Create() =>
        new Style<Slider>()
            .AddAppThemeBinding(Slider.MinimumTrackColorProperty, ApplicationColorsDictionary.Primary, ApplicationColorsDictionary.White)
            .AddAppThemeBinding(Slider.MaximumTrackColorProperty, ApplicationColorsDictionary.Gray200, ApplicationColorsDictionary.Gray600)
            .AddAppThemeBinding(Slider.ThumbColorProperty, ApplicationColorsDictionary.Primary, ApplicationColorsDictionary.White)
            .AddVisualStateGroupList(groups =>
                groups.AddItem("CommonStates", group =>
                {
                    group.Add("Normal");
                    group.Add("Disabled", state =>
                    {
                        state.AddAppThemeBinding(Slider.MinimumTrackColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600);
                        state.AddAppThemeBinding(Slider.MaximumTrackColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600);
                        state.AddAppThemeBinding(Slider.ThumbColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600);
                    });
                }));
}