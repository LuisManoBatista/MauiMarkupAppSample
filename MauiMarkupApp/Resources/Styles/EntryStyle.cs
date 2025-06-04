using CommunityToolkit.Maui.Markup;
using MauiMarkupApp.Resources.Styles.Extensions;

namespace MauiMarkupApp.Resources.Styles;

public static class EntryStyle
{
    public static Style Create() =>
        new Style<Entry>()
            .AddAppThemeBinding(Entry.TextColorProperty, ApplicationColorsDictionary.Black, ApplicationColorsDictionary.White)
            .AddAppThemeBinding(Entry.PlaceholderColorProperty, ApplicationColorsDictionary.Gray200, ApplicationColorsDictionary.Gray500)
            .Add(VisualElement.BackgroundColorProperty, ApplicationColorsDictionary.Transparent)
            .Add(Entry.FontFamilyProperty, "OpenSansRegular")
            .Add(Entry.FontSizeProperty, 14)
            .Add(VisualElement.MinimumHeightRequestProperty, 44)
            .Add(VisualElement.MinimumWidthRequestProperty, 44)
            .AddVisualStateGroupList(groups =>
                groups.AddItem("CommonStates", group =>
                {
                    group.Add("Normal");
                    group.Add("Disabled", state =>
                        state.AddAppThemeBinding(Entry.TextColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600));
                }));
}