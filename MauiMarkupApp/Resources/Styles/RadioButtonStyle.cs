using CommunityToolkit.Maui.Markup;
using MauiMarkupApp.Resources.Styles.Extensions;

namespace MauiMarkupApp.Resources.Styles;

public static class RadioButtonStyle
{
    public static Style Create() =>
        new Style<RadioButton>()
            .AddAppThemeBinding(RadioButton.TextColorProperty, ApplicationColorsDictionary.Black, ApplicationColorsDictionary.White)
            .Add(VisualElement.BackgroundColorProperty, ApplicationColorsDictionary.Transparent)
            .Add(RadioButton.FontFamilyProperty, "OpenSansRegular")
            .Add(RadioButton.FontSizeProperty, 14)
            .Add(VisualElement.MinimumHeightRequestProperty, 44)
            .Add(VisualElement.MinimumWidthRequestProperty, 44)
            .AddVisualStateGroupList(groups =>
                groups.AddItem("CommonStates", group =>
                {
                    group.Add("Normal");
                    group.Add("Disabled", state =>
                        state.AddAppThemeBinding(RadioButton.TextColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600));
                }));
}