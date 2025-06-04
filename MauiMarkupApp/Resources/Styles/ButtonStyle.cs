using CommunityToolkit.Maui.Markup;
using MauiMarkupApp.Resources.Styles.Extensions;

namespace MauiMarkupApp.Resources.Styles;

public static class ButtonStyle
{
    public static Style Create() =>
        new Style<Button>()
            .AddAppThemeBinding(Button.TextColorProperty, ApplicationColorsDictionary.White, ApplicationColorsDictionary.PrimaryDarkText)
            .AddAppThemeBinding(VisualElement.BackgroundColorProperty, ApplicationColorsDictionary.Primary, ApplicationColorsDictionary.PrimaryDark)
            .Add(Button.FontFamilyProperty, "OpenSansRegular")
            .Add(Button.FontSizeProperty, 14)
            .Add(Button.BorderWidthProperty, 0)
            .Add(Button.CornerRadiusProperty, 8)
            .Add(Button.PaddingProperty, new Thickness(14, 10))
            .Add(VisualElement.MinimumHeightRequestProperty, 44)
            .Add(VisualElement.MinimumWidthRequestProperty, 44)
            .AddVisualStateGroupList(groups =>
                groups.AddItem("CommonStates", group => 
                {
                    group.Add("Normal");
                    group.Add("Disabled", state =>
                    {
                        state.AddAppThemeBinding(Button.TextColorProperty, ApplicationColorsDictionary.Gray950, ApplicationColorsDictionary.Gray200);
                        state.AddAppThemeBinding(VisualElement.BackgroundColorProperty, ApplicationColorsDictionary.Gray200, ApplicationColorsDictionary.Gray600);
                    });
                    group.Add("PointerOver");
                }));
}