using CommunityToolkit.Maui.Markup;
using MauiMarkupApp.Resources.Styles.Extensions;

namespace MauiMarkupApp.Resources.Styles;

public static class SearchBarStyle
{
    public static Style Create() =>
        new Style<SearchBar>()
            .AddAppThemeBinding(SearchBar.TextColorProperty, ApplicationColorsDictionary.Gray900, ApplicationColorsDictionary.White)
            .Add(SearchBar.PlaceholderColorProperty, ApplicationColorsDictionary.Gray500)
            .Add(SearchBar.CancelButtonColorProperty, ApplicationColorsDictionary.Gray500)
            .Add(VisualElement.BackgroundColorProperty, ApplicationColorsDictionary.Transparent)
            .Add(SearchBar.FontFamilyProperty, "OpenSansRegular")
            .Add(SearchBar.FontSizeProperty, 14)
            .Add(VisualElement.MinimumHeightRequestProperty, 44)
            .Add(VisualElement.MinimumWidthRequestProperty, 44)
            .AddVisualStateGroupList(groups =>
                groups.AddItem("CommonStates", group =>
                {
                    group.Add("Normal");
                    group.Add("Disabled", state =>
                    {
                        state.AddAppThemeBinding(SearchBar.TextColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600);
                        state.AddAppThemeBinding(SearchBar.PlaceholderColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600);
                    });
                }));
}