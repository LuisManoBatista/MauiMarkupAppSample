using CommunityToolkit.Maui.Markup;
using MauiMarkupApp.Resources.Styles.Extensions;

namespace MauiMarkupApp.Resources.Styles;

public static class PickerStyle
{
    public static Style Create() =>
        new Style<Picker>()
            .AddAppThemeBinding(Picker.TextColorProperty, ApplicationColorsDictionary.Gray900, ApplicationColorsDictionary.White)
            .AddAppThemeBinding(Picker.TitleColorProperty, ApplicationColorsDictionary.Gray900, ApplicationColorsDictionary.Gray200)
            .Add(VisualElement.BackgroundColorProperty, ApplicationColorsDictionary.Transparent)
            .Add(Picker.FontFamilyProperty, "OpenSansRegular")
            .Add(Picker.FontSizeProperty, 14)
            .Add(VisualElement.MinimumHeightRequestProperty, 44)
            .Add(VisualElement.MinimumWidthRequestProperty, 44)
            .AddVisualStateGroupList(groups =>
                groups.AddItem("CommonStates", group =>
                {
                    group.Add("Normal");
                    group.Add("Disabled", state =>
                    {
                        state.AddAppThemeBinding(Picker.TextColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600);
                        state.AddAppThemeBinding(Picker.TitleColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600);
                    });
                }));
}