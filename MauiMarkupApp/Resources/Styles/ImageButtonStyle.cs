using CommunityToolkit.Maui.Markup;
using MauiMarkupApp.Resources.Styles.Extensions;

namespace MauiMarkupApp.Resources.Styles;

public static class ImageButtonStyle
{
    public static Style Create() =>
        new Style<ImageButton>()
            .Add(VisualElement.OpacityProperty, 1)
            .Add(ImageButton.BorderColorProperty, ApplicationColorsDictionary.Transparent)
            .Add(ImageButton.BorderWidthProperty, 0)
            .Add(ImageButton.CornerRadiusProperty, 0)
            .Add(VisualElement.MinimumHeightRequestProperty, 44)
            .Add(VisualElement.MinimumWidthRequestProperty, 44)
            .AddVisualStateGroupList(groups =>
                groups.AddItem("CommonStates", group =>
                {
                    group.Add("Normal");
                    group.Add("Disabled", state =>
                        state.Add(VisualElement.OpacityProperty, 0.5));
                    group.Add("PointerOver");
                }));
}