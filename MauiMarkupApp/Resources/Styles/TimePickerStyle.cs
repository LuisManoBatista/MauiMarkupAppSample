using CommunityToolkit.Maui.Markup;
using MauiMarkupApp.Resources.Styles.Extensions;

namespace MauiMarkupApp.Resources.Styles;

public static class TimePickerStyle
{
    public static Style Create() =>
        new Style<TimePicker>()
            .AddAppThemeBinding(Button.TextColorProperty, ApplicationColorsDictionary.White, ApplicationColorsDictionary.PrimaryDarkText)
            .Add(VisualElement.BackgroundColorProperty, ApplicationColorsDictionary.Transparent)
            .Add(TimePicker.FontFamilyProperty, "OpenSansRegular")
            .Add(TimePicker.FontSizeProperty, 14)
            .Add(VisualElement.MinimumHeightRequestProperty, 44)
            .Add(VisualElement.MinimumWidthRequestProperty, 44)
            .Add(VisualStateManager.VisualStateGroupsProperty,
                new VisualStateGroupList()
                    .AddItem("CommonStates", (x) => x
                        .Add("Normal")
                        .Add("Disabled", s => s
                            .AddAppThemeBinding(Button.TextColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600) )
                        .Add("PointerOver")));
 }