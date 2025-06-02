using CommunityToolkit.Maui.Markup;

namespace MauiMarkupApp.Resources.Styles;

public static class BorderStyle
{
    public static Style Create() => new Style<Border>()
        .AddAppThemeBinding(Border.StrokeProperty, ApplicationColorsDictionary.Gray200, ApplicationColorsDictionary.Gray500)
        .Add(Border.StrokeShapeProperty, new Microsoft.Maui.Controls.Shapes.Rectangle())
        .Add(Border.StrokeThicknessProperty, 1);
}