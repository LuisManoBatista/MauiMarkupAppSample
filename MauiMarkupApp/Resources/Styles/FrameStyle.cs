using CommunityToolkit.Maui.Markup;

namespace MauiMarkupApp.Resources.Styles;

[Obsolete("FrameStyle is deprecated and will be removed in a future release. Use alternative styling methods.")]
public static class FrameStyle
{
    public static Style Create() =>
        new Style<Frame>()
            .AddAppThemeBinding(Frame.BorderColorProperty, ApplicationColorsDictionary.Gray200, ApplicationColorsDictionary.Gray950)
            .AddAppThemeBinding(VisualElement.BackgroundColorProperty, ApplicationColorsDictionary.White, ApplicationColorsDictionary.Black)
            .Add(Frame.HasShadowProperty, false)
            .Add(Frame.CornerRadiusProperty, 8);
}