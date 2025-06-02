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
            .Add(VisualStateManager.VisualStateGroupsProperty,
                new VisualStateGroupList()
                    .AddItem( "CommonStates", (x) => x
                        .Add( "Normal" )
                        .Add( "Disabled", s => s
                            .AddAppThemeBinding( Button.TextColorProperty, ApplicationColorsDictionary.Gray950, ApplicationColorsDictionary.Gray200 )
                            .AddAppThemeBinding( VisualElement.BackgroundColorProperty, ApplicationColorsDictionary.Gray200, ApplicationColorsDictionary.Gray600))
                        .Add( "PointerOver" )));
}