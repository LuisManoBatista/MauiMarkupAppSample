using CommunityToolkit.Maui.Markup;
using MauiMarkupApp.Resources.Styles.Extensions;

namespace MauiMarkupApp.Resources.Styles;

public static class EditorStyle
{
    public static Style Create() =>
        new Style<Editor>()
            .AddAppThemeBinding(Editor.TextColorProperty, ApplicationColorsDictionary.Black, ApplicationColorsDictionary.White)
            .AddAppThemeBinding(Editor.PlaceholderColorProperty, ApplicationColorsDictionary.Gray200, ApplicationColorsDictionary.Gray500)
            .Add(VisualElement.BackgroundColorProperty, ApplicationColorsDictionary.Transparent)
            .Add(Editor.FontFamilyProperty, "OpenSansRegular")
            .Add(Editor.FontSizeProperty, 14)
            .Add(VisualElement.MinimumHeightRequestProperty, 44)
            .Add(VisualElement.MinimumWidthRequestProperty, 44)
            .AddVisualStateGroupList(groups =>
                groups.AddItem("CommonStates", group =>
                {
                    group.Add("Normal");
                    group.Add("Disabled", state =>
                        state.AddAppThemeBinding(Editor.TextColorProperty, ApplicationColorsDictionary.Gray300, ApplicationColorsDictionary.Gray600));
                }));
}