using CommunityToolkit.Maui.Markup;
using MauiMarkupApp.Resources.Styles.Extensions;

namespace MauiMarkupApp.Resources.Styles;

public static class SearchHandlerStyle
{
    public static Style Create() =>
        new Style<SearchHandler>()
            .AddAppThemeBinding(SearchHandler.TextColorProperty, ApplicationColorsDictionary.Gray900, ApplicationColorsDictionary.White)
            .Add(SearchHandler.PlaceholderColorProperty, ApplicationColorsDictionary.Gray500)
            .Add(VisualElement.BackgroundColorProperty, ApplicationColorsDictionary.Transparent)
            .Add(SearchHandler.FontFamilyProperty, "OpenSansRegular")
            .Add(SearchHandler.FontSizeProperty, 14)
            .AddVisualStateGroupList(groups =>
                groups.AddItem("CommonStates", group =>
                {
                    group.Add("Normal");
                    group.Add("Disabled", state =>
                    {
                        state.AddAppThemeBinding(SearchHandler.TextColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600);
                        state.AddAppThemeBinding(SearchHandler.PlaceholderColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600);
                    });
                }));
}