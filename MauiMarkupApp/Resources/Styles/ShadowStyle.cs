using CommunityToolkit.Maui.Markup;

namespace MauiMarkupApp.Resources.Styles;

public static class ShadowStyle
{
    public static Style Create() =>
        new Style<Shadow>()
            .AddAppThemeBinding(Shadow.BrushProperty, ApplicationColorsDictionary.White, ApplicationColorsDictionary.White)
            .Add(Shadow.RadiusProperty, 15)
            .Add(Shadow.OpacityProperty, 0.5)
            .Add(Shadow.OffsetProperty, new Microsoft.Maui.Graphics.Point(10, 10));
}