using CommunityToolkit.Maui.Markup;
using MauiMarkupApp.Resources.Styles.Extensions;

namespace MauiMarkupApp.Resources.Styles;

public static class LabelStyle
{
    public static Style Create() =>
        new Style<Label>()
            .AddAppThemeBinding(Label.TextColorProperty, ApplicationColorsDictionary.Black, ApplicationColorsDictionary.White)
            .Add(VisualElement.BackgroundColorProperty, ApplicationColorsDictionary.Transparent)
            .Add(Label.FontFamilyProperty, "OpenSansRegular")
            .Add(Label.FontSizeProperty, 14)
            .AddVisualStateGroupList(groups =>
                groups.AddItem("CommonStates", group =>
                {
                    group.Add("Normal");
                    group.Add("Disabled", state =>
                        state.AddAppThemeBinding(Label.TextColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600));
                }));
}