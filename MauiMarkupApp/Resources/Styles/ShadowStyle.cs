namespace MauiMarkupApp.Resources.Styles;

public static class ShadowStyle
{
    public static Style Create() => new(typeof(Shadow))
    {
        Setters =
        {
            ApplicationStylesDictionary.SimpleSetter(Shadow.RadiusProperty, 15),
            ApplicationStylesDictionary.SimpleSetter(Shadow.OpacityProperty, 0.5),
            ApplicationStylesDictionary.AppThemeBinding(Shadow.BrushProperty, ApplicationColorsDictionary.White, ApplicationColorsDictionary.White),
            ApplicationStylesDictionary.SimpleSetter(Shadow.OffsetProperty, new Microsoft.Maui.Graphics.Point(10, 10))
        }
    };
}