using CommunityToolkit.Maui.Markup;
using MauiMarkupApp.Resources.Styles.Extensions;

namespace MauiMarkupApp.Resources.Styles;

public static class DatePickerStyle
{
    public static Style Create() =>
        new Style<DatePicker>()
            .AddAppThemeBinding(DatePicker.TextColorProperty, ApplicationColorsDictionary.Gray900, ApplicationColorsDictionary.White)
            .Add(VisualElement.BackgroundColorProperty, ApplicationColorsDictionary.Transparent)
            .Add(DatePicker.FontFamilyProperty, "OpenSansRegular")
            .Add(DatePicker.FontSizeProperty, 14)
            .Add(VisualElement.MinimumHeightRequestProperty, 44)
            .Add(VisualElement.MinimumWidthRequestProperty, 44)
            .AddVisualStateGroupList(groups => 
                groups.AddItem("CommonStates", group =>
                {
                    group.Add("Normal");
                    group.Add("Disabled", state =>
                        state.AddAppThemeBinding(DatePicker.TextColorProperty, ApplicationColorsDictionary.Gray200, ApplicationColorsDictionary.Gray500));
                }));
}